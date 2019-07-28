using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CalendarWithBase.ViewModel
{
    public class EditEventCommand : ICommand
    {
        public EditEventCommand()
        {
        }

        public void Execute(object parameter)
        {
            String parameterString = parameter as String;
            if (parameterString == null)
                throw new Exception();

            DateTime chosenDate = CalendarWithBase.Model.Calendar.getInstance().dateTime;
            chosenDate = chosenDate.AddDays(Int32.Parse(parameterString) - 1);
            String chosenDayLabelContent = (String) ViewModel.MainWindowViewModel.getInstance().DayLabelsArray.GetValue(Int32.Parse(parameterString) - 1);

            Model.DayEvent chosenDayEvent = new Model.DayEvent(
                chosenDayLabelContent.Substring(12, chosenDayLabelContent.Length - 12),
                new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(0, 2)), Int32.Parse(chosenDayLabelContent.Substring(3, 2)), 1),
                new DateTime(chosenDate.Year, chosenDate.Month, chosenDate.Day, Int32.Parse(chosenDayLabelContent.Substring(6, 2)), Int32.Parse(chosenDayLabelContent.Substring(9, 2)), 1)
                );
            View.EditEventWindow editEventWindow = new View.EditEventWindow(chosenDayEvent);
            editEventWindow.ShowDialog();
        }

        public bool CanExecute(object parameter) { return true; }
        public event EventHandler CanExecuteChanged;
    }
}
