using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;
using System.Windows.Controls;
using System.Windows.Media;
using System.ComponentModel;
using CalendarWithBase.Model;
using System.Data.SqlClient;

namespace CalendarWithBase.ViewModel
{
    public class MainWindowViewModel : INotifyPropertyChanged
    {
        private static MainWindowViewModel instance;
        private ICommand ButtonCommandInstance;
        private AddEventCommand AddEventCommandInstance;
        private EditEventCommand EditEventCommandInstance;

        public CalendarDatabaseEntities databaseContext;

        public String username;
        
        public System.Windows.Media.Brush WindowColor { get; set; }
        public System.Windows.Media.Brush GeneralLabelColor { get; set; }
        public System.Windows.Media.Brush ButtonColor { get; set; }
        public System.Windows.Media.Brush DayLabelColor { get; set; }
        public System.Windows.Media.Brush MarkedDayLabelColor { get; set; }
        public System.Windows.Media.FontFamily FontType { get; set; }

        private System.Windows.Media.Brush[] dayLabelBackgroundsArray = new System.Windows.Media.Brush[28];
        public Array DayLabelBackgroundsArray { get { return dayLabelBackgroundsArray; } }

        private String[] weekLabelsArray = new String[4];
        public Array WeekLabelsArray { get { return weekLabelsArray; } }

        private String[] dayLabelsArray = new String[28];
        public Array DayLabelsArray { get { return dayLabelsArray; } }

        private Label[] labelsArray = new Label[28];
        private StackPanel[] stackPanelsArray = new StackPanel[28];

        public event PropertyChangedEventHandler PropertyChanged;
        private PropertyChangedEventArgs WeekLabelsArrayChangedEventArgs = new PropertyChangedEventArgs("WeeklabelsArray");
        private PropertyChangedEventArgs DayLabelBackgroundsArrayChangedEventArgs = new PropertyChangedEventArgs("DayLabelBackgroundsArray");
        private PropertyChangedEventArgs WindowColorChangedEventArgs = new PropertyChangedEventArgs("WindowColor");
        private PropertyChangedEventArgs GeneralLabelColorChangedEventArgs = new PropertyChangedEventArgs("GeneralLabelColor");
        private PropertyChangedEventArgs ButtonColorChangedEventArgs = new PropertyChangedEventArgs("ButtonColor");
        private PropertyChangedEventArgs DayLabelColorChangedEventArgs = new PropertyChangedEventArgs("DayLabelColor");
        private PropertyChangedEventArgs MarkedDayLabelColorChangedEventArgs = new PropertyChangedEventArgs("MarkedDayLabelColor");
        private PropertyChangedEventArgs FontTypeChangedEventArgs = new PropertyChangedEventArgs("FontType");

        public ICommand ButtonCommandProperty
        {
            get
            {
                return ButtonCommandInstance ?? (ButtonCommandInstance = new ButtonCommand(this));
            }
        }

        public ICommand AddEventCommandProperty
        {
            get
            {
                return AddEventCommandInstance ?? (AddEventCommandInstance = new AddEventCommand());
            }
        }

        public ICommand EditEventCommandProperty
        {
            get
            {
                return null;//EditEventCommandInstance ?? (EditEventCommandInstance = new EditEventCommand());
            }
        }

        public MainWindowViewModel()
        {
            this.databaseContext = new CalendarDatabaseEntities();
            if (!this.databaseContext.DatabaseExists())
            {
                //this.databaseContext.CreateDatabase();
                SqlConnection connection = new SqlConnection(@"server=X51RL-PC;Trusted_Connection=Yes;");
                using (connection)
                {
                    string sqlQuery = string.Format(@"
                    CREATE DATABASE
                        [NTR2017]
                    ON PRIMARY (
                       NAME=Calendar_data,
                       FILENAME = '{0}\Calendar_data.mdf'
                    )
                    LOG ON (
                        NAME=Calendar_log,
                        FILENAME = '{0}\Calendar_log.ldf'
                    )",
                        @"C:\Program Files\Microsoft SQL Server\MSSQL10.MSSQLSERVER\MSSQL\DATA"
                    );

                    SqlCommand command = new SqlCommand(sqlQuery, connection);
                    command.Connection.Open();
                    command.ExecuteNonQuery();
                }
                Console.WriteLine("New calendar database created");
            }

            WindowColor = new SolidColorBrush(Color.FromRgb(255, 255, 255));
            GeneralLabelColor = new SolidColorBrush(Color.FromRgb(198, 179, 255));
            ButtonColor = new SolidColorBrush(Color.FromRgb(152, 230, 230));
            DayLabelColor = new SolidColorBrush(Color.FromRgb(173, 235, 173));
            MarkedDayLabelColor = new SolidColorBrush(Color.FromRgb(255, 153, 153));

            int currentDayOfYear = Model.Calendar.getInstance().dateTime.DayOfYear;

            for (int i = 0; i < 4; i++)
                weekLabelsArray[i] = "W" + ((currentDayOfYear / 7) + i + 1).ToString() + "\n2017";

            Model.Calendar.getInstance().NormalizeWeek();
            for (int i = 0; i < 28; i++)
            {
                dayLabelsArray[i] = Model.Calendar.getInstance().Months[Model.Calendar.getInstance().dateTime.Month - 1]
                     + " " + Model.Calendar.getInstance().dateTime.Day.ToString();

                if (Model.Calendar.getInstance().dateTime.CompareTo(Model.Calendar.getInstance().currentDateTime) == 0)
                    this.DayLabelBackgroundsArray.SetValue(MarkedDayLabelColor, i);
                else
                    this.DayLabelBackgroundsArray.SetValue(DayLabelColor, i);
                Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(1);
            }
            Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(-28);
            EditEventCommandInstance = new EditEventCommand();
        }

        public static MainWindowViewModel getInstance()
        {
            if (instance == null)
                instance = new MainWindowViewModel();
            return instance; 
        }

        public void ClearDatabase()
        {
            SqlConnection connection = new SqlConnection(@"Data Source=X51RL-PC;Initial Catalog=NTR2017;Integrated Security=True;MultipleActiveResultSets=True;");
            using (connection)
            {
                connection.Open();

                string sqlQuery = @"delete from DayEvents";

                SqlCommand command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();

                sqlQuery = @"delete from Users";

                command = new SqlCommand(sqlQuery, connection);
                command.ExecuteNonQuery();
            }
        }

        public void WriteAllEventsFromListToDatabase()
        {
            for (int i = 0; i < CalendarWithBase.Model.Calendar.getInstance().dayEventsList.Count; i++)
            {
                DayEvents dayEventInDataBase = new DayEvents()
                {
                    username = this.username,
                    eventDescription = ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[i]).GetDescription(),
                    startTime = ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[i]).GetStartTime(),
                    endTime = ((DayEvent)CalendarWithBase.Model.Calendar.getInstance().dayEventsList[i]).GetEndTime()
                };
                databaseContext.DayEvents.AddObject(dayEventInDataBase);
            }
            databaseContext.SaveChanges();
        }

        public void ReadAllUserEventsFromDatabaseToList()
        {
            //DayEvents[] dayEventsArray = databaseContext.DayEvents.ToArray();
            DayEvent dayEvent;

            for (int i = 0; i < databaseContext.DayEvents.Count(); i++)
            {
                if (databaseContext.DayEvents.AsEnumerable().ElementAt(i).username == this.username)
                {
                    dayEvent = new DayEvent(
                    databaseContext.DayEvents.AsEnumerable().ElementAt(i).eventDescription,
                    databaseContext.DayEvents.AsEnumerable().ElementAt(i).startTime,
                    databaseContext.DayEvents.AsEnumerable().ElementAt(i).endTime);
                    
                    CalendarWithBase.Model.Calendar.getInstance().dayEventsList.Add(dayEvent);
                }                
            }
            CalendarWithBase.Model.Calendar.getInstance().dayEventsList.Sort(new DayEventsComparer());
        }

        public void setControlsArrays(Label[] labelsArray, StackPanel[] stackPanelsArray)
        {
            this.stackPanelsArray = stackPanelsArray;
            this.labelsArray = labelsArray;
        }

        public void UpdateDayLabelBackgrounds()
        {
            for (int i = 0; i < 28; i++)
            {
                if (Model.Calendar.getInstance().dateTime.CompareTo(Model.Calendar.getInstance().currentDateTime) == 0)
                    this.DayLabelBackgroundsArray.SetValue(MarkedDayLabelColor, i);
                else
                    this.DayLabelBackgroundsArray.SetValue(DayLabelColor, i);
                Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(1);
            }
            Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(-28);
            PropertyChanged.Invoke(this, DayLabelBackgroundsArrayChangedEventArgs);
        }

        public void DisplayDayLabels()
        {
            for (int i = 0; i < 28; i++)
            {
                labelsArray[i].Content = Model.Calendar.getInstance().Months[Model.Calendar.getInstance().dateTime.Month - 1]
                     + " " + Model.Calendar.getInstance().dateTime.Day.ToString();
                Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(1);
            }
            Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(-28);
        }

        public void UpdateWeekLabels()
        {
            int currentDayOfYear = Model.Calendar.getInstance().dateTime.DayOfYear;

            for (int i = 0; i < 4; i++)
                weekLabelsArray[i] = "W" + ((currentDayOfYear / 7) + i + 1).ToString() + "\n2017";

            PropertyChanged.Invoke(this, WeekLabelsArrayChangedEventArgs);
        }
        
        public void UpdateFontType()
        {
            PropertyChanged.Invoke(this, FontTypeChangedEventArgs);
        }

        public void UpdateControlColors()
        {
            PropertyChanged.Invoke(this, WindowColorChangedEventArgs);
            PropertyChanged.Invoke(this, GeneralLabelColorChangedEventArgs);
            PropertyChanged.Invoke(this, ButtonColorChangedEventArgs);
            PropertyChanged.Invoke(this, DayLabelColorChangedEventArgs);
            PropertyChanged.Invoke(this, MarkedDayLabelColorChangedEventArgs);
            PropertyChanged.Invoke(this, DayLabelBackgroundsArrayChangedEventArgs);
        }

        public void UpdateDisplay(Object parameter)
        {
            //Console.WriteLine("UpdateDisplay");

            String parameterString = parameter as String;
            
            if (parameterString == null)
                throw new Exception();
            Console.WriteLine(labelsArray[4].Content);
            if (parameterString.Equals("prev"))
            {
                //UnmarkCurrentDay();
                Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(-7);
                UpdateWeekLabels();
                DisplayDayLabels();
                UpdateDayLabelBackgrounds();
                DisplayEvents();
            }
            else if (parameterString.Equals("next"))
            {
                //UnmarkCurrentDay();
                Model.Calendar.getInstance().dateTime = Model.Calendar.getInstance().dateTime.AddDays(7);
                UpdateWeekLabels();
                DisplayDayLabels();
                UpdateDayLabelBackgrounds();
                DisplayEvents();
            }
        }

        public void ClearEvents()
        {
            for (int i = 0; i < 28; i++)
                stackPanelsArray[i].Children.Clear();
        }

        public void DisplayEvents()
        {
            TimeSpan differenceTimeSpan;
            int dayNumber;
            Label label;

            ClearEvents();

            foreach (DayEvent dayEvent in CalendarWithBase.Model.Calendar.getInstance().dayEventsList)
            {
                differenceTimeSpan = dayEvent.GetStartTime() - CalendarWithBase.Model.Calendar.getInstance().dateTime;

                if (0 <= differenceTimeSpan.Days && differenceTimeSpan.Days < 28)
                {
                    dayNumber = differenceTimeSpan.Days;
                    label = new Label();
                    label.Background = Brushes.White;
                    label.BorderBrush = Brushes.Black;
                    label.FontSize = 10;
                    label.Height = 23;
                    label.BorderThickness = new System.Windows.Thickness(0.7);
                    label.Content =
                        (dayEvent.GetStartTime().Hour.ToString().Length == 1 ? "0" + dayEvent.GetStartTime().Hour.ToString() : dayEvent.GetStartTime().Hour.ToString())
                        + ":" + (dayEvent.GetStartTime().Minute.ToString().Length == 1 ? "0" + dayEvent.GetStartTime().Minute.ToString() : dayEvent.GetStartTime().Minute.ToString())
                        + "-" + (dayEvent.GetEndTime().Hour.ToString().Length == 1 ? "0" + dayEvent.GetEndTime().Hour.ToString() : dayEvent.GetEndTime().Hour.ToString())
                        + ":" + (dayEvent.GetEndTime().Minute.ToString().Length == 1 ? "0" + dayEvent.GetEndTime().Minute.ToString() : dayEvent.GetEndTime().Minute.ToString())
                        + " " + dayEvent.GetDescription();
                    stackPanelsArray[dayNumber].Children.Add(label);
                }
            }
        }
    }
}
