using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CalendarWithBase.Model
{
    public class DayEvent
    {
        private String description;
        private DateTime startTime;
        private DateTime endTime;

        public DayEvent(String description, DateTime startTime, DateTime endTime)
        {
            this.description = description;
            this.startTime = startTime;
            this.endTime = endTime;
        }

        public void SetDescription(String description)
        { 
            this.description = description;
        }

        public String GetDescription()
        {
            return this.description;
        }

        public DateTime GetStartTime()
        {
            return this.startTime;
        }

        public void SetStartTime(DateTime startTime)
        {
            this.startTime = startTime;
        }

        public DateTime GetEndTime()
        {
            return this.endTime;
        }

        public void SetEndTime(DateTime endTime)
        {
            this.endTime = endTime;
        }
    }
}
