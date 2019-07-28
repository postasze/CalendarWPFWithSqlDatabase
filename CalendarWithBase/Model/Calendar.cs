using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Globalization;
using System.ComponentModel;
using System.Collections;

namespace CalendarWithBase.Model
{
    public class Calendar
    {
        private static Calendar instance;
        public GregorianCalendar gregorianCalendar;
        public DateTime dateTime;
        public DateTime currentDateTime;
        public ArrayList dayEventsList;

        public String[] Months = new String[] 
        { "January", 
          "February", 
          "March", 
          "April", 
          "May", 
          "June", 
          "July", 
          "August", 
          "September", 
          "October", 
          "November", 
          "December" 
        };

        public Calendar()
        {
            //Console.WriteLine("Calendar constructor");
            gregorianCalendar = new GregorianCalendar();
            currentDateTime = DateTime.Now;
            currentDateTime = currentDateTime.AddHours(-currentDateTime.Hour);
            currentDateTime = currentDateTime.AddMinutes(-currentDateTime.Minute);
            currentDateTime = currentDateTime.AddSeconds(-currentDateTime.Second);
            currentDateTime = currentDateTime.AddMilliseconds(-currentDateTime.Millisecond);
            dateTime = currentDateTime;
            this.dayEventsList = new ArrayList();
        }

        public static Calendar getInstance()
        {
            if (instance == null)
                instance = new Calendar();
            return instance;
        }

        public void NormalizeWeek()
        {
            switch (dateTime.DayOfWeek)
            {
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    dateTime = dateTime.AddDays(-1);
                    break;
                case DayOfWeek.Wednesday:
                    dateTime = dateTime.AddDays(-2);
                    break;
                case DayOfWeek.Thursday:
                    dateTime = dateTime.AddDays(-3);
                    break;
                case DayOfWeek.Friday:
                    dateTime = dateTime.AddDays(-4);
                    break;
                case DayOfWeek.Saturday:
                    dateTime = dateTime.AddDays(-5);
                    break;
                case DayOfWeek.Sunday:
                    dateTime = dateTime.AddDays(-6);
                    break;
            }
        }
    }
}
