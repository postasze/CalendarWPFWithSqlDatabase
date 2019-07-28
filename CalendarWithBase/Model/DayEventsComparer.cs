using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace CalendarWithBase.Model
{
    public class DayEventsComparer : IComparer  {

      int IComparer.Compare( Object x, Object y )  {
          DayEvent DayEvent1 = (DayEvent) x;
          DayEvent DayEvent2 = (DayEvent) y;

          return DateTime.Compare(DayEvent1.GetStartTime(), DayEvent2.GetStartTime());
      }

    }
}
