using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using CalendarWithBase.Model;
using System.Data.SqlClient;

namespace CalendarWithBase.View
{
    /// <summary>
    /// Interaction logic for EditEventWindow.xaml
    /// </summary>
    public partial class EditEventWindow : Window
    {
        private DayEvent chosenDayEvent;

        public EditEventWindow(DayEvent chosenDayEvent)
        {
            InitializeComponent();
            this.chosenDayEvent = chosenDayEvent;

            for (int i = 0; i < 24; i++)
            {
                this.startHourComboBox.Items.Add(i.ToString());
                this.endHourComboBox.Items.Add(i.ToString());
            }

            for (int i = 0; i < 60; i++)
            {
                this.startMinuteComboBox.Items.Add(i.ToString());
                this.endMinuteComboBox.Items.Add(i.ToString());
            }

            this.descriptionTextBox.Text = chosenDayEvent.GetDescription();
            this.startHourComboBox.SelectedIndex = chosenDayEvent.GetStartTime().Hour;
            this.startMinuteComboBox.SelectedIndex = chosenDayEvent.GetStartTime().Minute;
            this.endHourComboBox.SelectedIndex = chosenDayEvent.GetEndTime().Hour;
            this.endMinuteComboBox.SelectedIndex = chosenDayEvent.GetEndTime().Minute;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            int index = CalendarWithBase.Model.Calendar.getInstance().dayEventsList.BinarySearch(chosenDayEvent, new DayEventsComparer());

            ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[index]).SetDescription(this.descriptionTextBox.Text);
            ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[index]).SetStartTime(new DateTime(chosenDayEvent.GetStartTime().Year, chosenDayEvent.GetStartTime().Month, chosenDayEvent.GetStartTime().Day, this.startHourComboBox.SelectedIndex, this.startMinuteComboBox.SelectedIndex, 1));
            ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[index]).SetEndTime(new DateTime(chosenDayEvent.GetEndTime().Year, chosenDayEvent.GetEndTime().Month, chosenDayEvent.GetEndTime().Day, this.endHourComboBox.SelectedIndex, this.endMinuteComboBox.SelectedIndex, 1));
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DisplayEvents();
            //DiskInputOutput.DiskManager.getInstance().WriteEventsToFile();

            DateTime newStartTime = new DateTime(chosenDayEvent.GetStartTime().Year, chosenDayEvent.GetStartTime().Month, chosenDayEvent.GetStartTime().Day, this.startHourComboBox.SelectedIndex, this.startMinuteComboBox.SelectedIndex, 1);
            DateTime newEndTime = new DateTime(chosenDayEvent.GetEndTime().Year, chosenDayEvent.GetEndTime().Month, chosenDayEvent.GetEndTime().Day, this.endHourComboBox.SelectedIndex, this.endMinuteComboBox.SelectedIndex, 1);

            SqlConnection connection = new SqlConnection(@"Data Source=X51RL-PC;Initial Catalog=NTR2017;Integrated Security=True;MultipleActiveResultSets=True;");
            using (connection)
            {
                string sqlQuery = string.Format(@"
                    UPDATE DayEvents
                    SET 
                    username = '{0}',
                    eventDescription = '{1}',
                    startTime = CAST('{2}' AS DATETIME),
                    endTime = CAST('{3}' AS DATETIME)
                    WHERE 
                    username = '{0}' AND
                    eventDescription = '{4}' AND
                    startTime = CAST('{5}' AS DATETIME) AND
                    endTime = CAST('{6}' AS DATETIME);",
                    ViewModel.MainWindowViewModel.getInstance().username,
                    descriptionTextBox.Text,
                    newStartTime,
                    newEndTime,
                    chosenDayEvent.GetDescription(),
                    chosenDayEvent.GetStartTime(),
                    chosenDayEvent.GetEndTime()
                );

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }

            //CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ClearDatabase();
            //CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().WriteAllEventsFromListToDatabase();
            this.Close();
        }

        private void eraseButton_Click(object sender, RoutedEventArgs e)
        {
            int index = CalendarWithBase.Model.Calendar.getInstance().dayEventsList.BinarySearch(chosenDayEvent, new DayEventsComparer());
            CalendarWithBase.Model.Calendar.getInstance().dayEventsList.RemoveAt(index);
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DisplayEvents();
            //DiskInputOutput.DiskManager.getInstance().WriteEventsToFile();

            SqlConnection connection = new SqlConnection(@"Data Source=X51RL-PC;Initial Catalog=NTR2017;Integrated Security=True;MultipleActiveResultSets=True;");
            using (connection)
            {
                string sqlQuery = string.Format(@"
                    DELETE FROM DayEvents
                    WHERE 
                    username = '{0}' AND
                    eventDescription = '{1}' AND
                    startTime = CAST('{2}' AS DATETIME) AND
                    endTime = CAST('{3}' AS DATETIME);",
                    ViewModel.MainWindowViewModel.getInstance().username,
                    chosenDayEvent.GetDescription(),
                    chosenDayEvent.GetStartTime(),
                    chosenDayEvent.GetEndTime()
                );

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.Connection.Open();
                command.ExecuteNonQuery();
            }

            /*DayEvents dayEventInDataBase = new DayEvents()
            {
                username = ViewModel.MainWindowViewModel.getInstance().username,
                eventDescription = descriptionTextBox.Text,
                startTime = startTime,
                endTime = endTime
            };*/

            //ViewModel.MainWindowViewModel.getInstance().databaseContext.DayEvents.DeleteObject(dayEventInDataBase);
            //ViewModel.MainWindowViewModel.getInstance().databaseContext.SaveChanges();
            this.Close();
        }
    }
}
