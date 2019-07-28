using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Input;

namespace CalendarWithBase.ViewModel
{
    public class AddEventCommand : ICommand
    {
        public AddEventCommand()
        {
        }

        public void Execute(object parameter)
        {
            String parameterString = parameter as String;
            if (parameterString == null)
                throw new Exception();

            DateTime chosenDate = Model.Calendar.getInstance().dateTime;
            chosenDate = chosenDate.AddDays(Int32.Parse(parameterString) - 1);
            View.AddEventWindow addEventWindow = new View.AddEventWindow(chosenDate);
            addEventWindow.ShowDialog();
        }

        public bool CanExecute(object parameter) { return true; }
        public event EventHandler CanExecuteChanged;
    }
}
