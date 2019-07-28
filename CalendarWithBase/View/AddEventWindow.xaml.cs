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

namespace CalendarWithBase.View
{
    /// <summary>
    /// Interaction logic for AddEventWindow.xaml
    /// </summary>
    public partial class AddEventWindow : Window
    {
        private DateTime chosenDate;

        public AddEventWindow(DateTime chosenDate)
        {
            InitializeComponent();
            for (int i = 0; i < 24; i++)
            {
                this.startHourComboBox.Items.Add(i.ToString());
                this.endHourComboBox.Items.Add(i.ToString());
            }
            this.startHourComboBox.SelectedIndex = 0;
            this.endHourComboBox.SelectedIndex = 0;

            for (int i = 0; i < 60; i++)
            {
                this.startMinuteComboBox.Items.Add(i.ToString());
                this.endMinuteComboBox.Items.Add(i.ToString());
            }
            this.startMinuteComboBox.SelectedIndex = 0;
            this.endMinuteComboBox.SelectedIndex = 0;
            this.chosenDate = chosenDate;
        }

        private void cancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void saveButton_Click(object sender, RoutedEventArgs e)
        {
            DayEvent dayEvent = new DayEvent(this.descriptionTextBox.Text,
                new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, this.startHourComboBox.SelectedIndex, this.startMinuteComboBox.SelectedIndex, 1),
                new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, this.endHourComboBox.SelectedIndex, this.endMinuteComboBox.SelectedIndex, 1));

            if (Model.Calendar.getInstance().dayEventsList.BinarySearch(dayEvent, new DayEventsComparer()) >= 0)
            {
                MessageBox.Show("To zdarzenie istnieje już w kalendarzu");
                return;
            }

            Model.Calendar.getInstance().dayEventsList.Add(dayEvent);
            Model.Calendar.getInstance().dayEventsList.Sort(new DayEventsComparer());
            ViewModel.MainWindowViewModel.getInstance().DisplayEvents();
            //DiskInputOutput.DiskManager.getInstance().WriteEventsToFile();

            DayEvents dayEventInDataBase = new DayEvents()
            {
                username = ViewModel.MainWindowViewModel.getInstance().username,
                eventDescription = dayEvent.GetDescription(),
                startTime = dayEvent.GetStartTime(),
                endTime = dayEvent.GetEndTime()
            };

            ViewModel.MainWindowViewModel.getInstance().databaseContext.DayEvents.AddObject(dayEventInDataBase);
            ViewModel.MainWindowViewModel.getInstance().databaseContext.SaveChanges();

            this.Close();
        }
    }
}
