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
using System.Windows.Navigation;
using System.Windows.Shapes;
using CalendarWithBase.Model;

namespace CalendarWithBase.View
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private StackPanel[] stackPanelsArray = new StackPanel[28];
        private Label[] labelsArray = new Label[28];
        private short[] clickCounts = new short[28];

        public MainWindow()
        {
            InitializeComponent();

            this.MinWidth = 600;
            this.MinHeight = 400;
            this.MaxWidth = 1801;
            this.MaxHeight = 1201;
            
            labelsArray[0] = Label1;
            labelsArray[1] = Label2;
            labelsArray[2] = Label3;
            labelsArray[3] = Label4;
            labelsArray[4] = Label5;
            labelsArray[5] = Label6;
            labelsArray[6] = Label7;
            labelsArray[7] = Label8;
            labelsArray[8] = Label9;
            labelsArray[9] = Label10;
            labelsArray[10] = Label11;
            labelsArray[11] = Label12;
            labelsArray[12] = Label13;
            labelsArray[13] = Label14;
            labelsArray[14] = Label15;
            labelsArray[15] = Label16;
            labelsArray[16] = Label17;
            labelsArray[17] = Label18;
            labelsArray[18] = Label19;
            labelsArray[19] = Label20;
            labelsArray[20] = Label21;
            labelsArray[21] = Label22;
            labelsArray[22] = Label23;
            labelsArray[23] = Label24;
            labelsArray[24] = Label25;
            labelsArray[25] = Label26;
            labelsArray[26] = Label27;
            labelsArray[27] = Label28;

            stackPanelsArray[0] = StackPanel1;
            stackPanelsArray[1] = StackPanel2;
            stackPanelsArray[2] = StackPanel3;
            stackPanelsArray[3] = StackPanel4;
            stackPanelsArray[4] = StackPanel5;
            stackPanelsArray[5] = StackPanel6;
            stackPanelsArray[6] = StackPanel7;
            stackPanelsArray[7] = StackPanel8;
            stackPanelsArray[8] = StackPanel9;
            stackPanelsArray[9] = StackPanel10;
            stackPanelsArray[10] = StackPanel11;
            stackPanelsArray[11] = StackPanel12;
            stackPanelsArray[12] = StackPanel13;
            stackPanelsArray[13] = StackPanel14;
            stackPanelsArray[14] = StackPanel15;
            stackPanelsArray[15] = StackPanel16;
            stackPanelsArray[16] = StackPanel17;
            stackPanelsArray[17] = StackPanel18;
            stackPanelsArray[18] = StackPanel19;
            stackPanelsArray[19] = StackPanel20;
            stackPanelsArray[20] = StackPanel21;
            stackPanelsArray[21] = StackPanel22;
            stackPanelsArray[22] = StackPanel23;
            stackPanelsArray[23] = StackPanel24;
            stackPanelsArray[24] = StackPanel25;
            stackPanelsArray[25] = StackPanel26;
            stackPanelsArray[26] = StackPanel27;
            stackPanelsArray[27] = StackPanel28;

            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().setControlsArrays(labelsArray, stackPanelsArray);
            //DiskInputOutput.DiskManager.getInstance().ReadEventsFromFile();
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ReadAllUserEventsFromDatabaseToList();
            CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().DisplayEvents();
            DataContext = CalendarWithBase.ViewModel.MainWindowViewModel.getInstance();
            //CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().ClearDatabase();
            //CalendarWithBase.ViewModel.MainWindowViewModel.getInstance().WriteAllEventsFromListToDatabase();
        }

        private void StackPanel1_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[0] = (short) ((clickCounts[0] + 1) % 2);
            if (clickCounts[0] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();   
            }
        }

        private void StackPanel2_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[1] = (short)((clickCounts[1] + 1) % 2);
            if (clickCounts[1] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(1);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel3_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[2] = (short)((clickCounts[2] + 1) % 2);
            if (clickCounts[2] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(2);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel4_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[3] = (short)((clickCounts[3] + 1) % 2);
            if (clickCounts[3] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(3);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel5_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[4] = (short)((clickCounts[4] + 1) % 2);
            if (clickCounts[4] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(4);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel6_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[5] = (short)((clickCounts[5] + 1) % 2);
            if (clickCounts[5] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(5);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel7_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[6] = (short)((clickCounts[6] + 1) % 2);
            if (clickCounts[6] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(6);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel8_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[7] = (short)((clickCounts[7] + 1) % 2);
            if (clickCounts[7] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(7);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel9_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[8] = (short)((clickCounts[8] + 1) % 2);
            if (clickCounts[8] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(8);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel10_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[9] = (short)((clickCounts[9] + 1) % 2);
            if (clickCounts[9] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(9);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel11_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[10] = (short)((clickCounts[10] + 1) % 2);
            if (clickCounts[10] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(10);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel12_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[11] = (short)((clickCounts[11] + 1) % 2);
            if (clickCounts[11] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(11);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel13_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[12] = (short)((clickCounts[12] + 1) % 2);
            if (clickCounts[12] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(12);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel14_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[13] = (short)((clickCounts[13] + 1) % 2);
            if (clickCounts[13] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(13);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel15_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[14] = (short)((clickCounts[14] + 1) % 2);
            if (clickCounts[14] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(14);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel16_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[15] = (short)((clickCounts[15] + 1) % 2);
            if (clickCounts[15] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(15);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel17_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[16] = (short)((clickCounts[16] + 1) % 2);
            if (clickCounts[16] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(16);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel18_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[17] = (short)((clickCounts[17] + 1) % 2);
            if (clickCounts[17] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(17);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel19_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[18] = (short)((clickCounts[18] + 1) % 2);
            if (clickCounts[18] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(18);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel20_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[19] = (short)((clickCounts[19] + 1) % 2);
            if (clickCounts[19] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(19);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel21_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[20] = (short)((clickCounts[20] + 1) % 2);
            if (clickCounts[20] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(20);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel22_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[21] = (short)((clickCounts[21] + 1) % 2);
            if (clickCounts[21] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(21);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel23_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[22] = (short)((clickCounts[22] + 1) % 2);
            if (clickCounts[22] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(22);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel24_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[23] = (short)((clickCounts[23] + 1) % 2);
            if (clickCounts[23] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(23);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel25_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[24] = (short)((clickCounts[24] + 1) % 2);
            if (clickCounts[24] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(24);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel26_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[25] = (short)((clickCounts[25] + 1) % 2);
            if (clickCounts[25] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(25);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel27_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[26] = (short)((clickCounts[26] + 1) % 2);
            if (clickCounts[26] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(26);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void StackPanel28_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            clickCounts[27] = (short)((clickCounts[27] + 1) % 2);
            if (clickCounts[27] == 0)
            {
                DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
                chosenDate = chosenDate.AddDays(27);
                Label chosenDayLabel = (Label)e.Source;
                String chosenDayLabelContent = (String)chosenDayLabel.Content;

                DayEvent chosenDayEvent = new DayEvent(
                    chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                    new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                    );
                EditEventWindow editEventWindow = new EditEventWindow(chosenDayEvent);
                editEventWindow.ShowDialog();
            }
        }

        private void Window_MouseRightButtonDown(object sender, MouseButtonEventArgs e)
        {
            if (!PopupMenu.active)
            {
                PopupMenu popupMenu = new PopupMenu();
                popupMenu.Show();
            }
        }
    }
}
