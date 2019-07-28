using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace CalendarWithBase.ViewModel
{
	public class ButtonCommand : ICommand
	{
        private CalendarWithBase.ViewModel.MainWindowViewModel viewModel;

        public ButtonCommand(CalendarWithBase.ViewModel.MainWindowViewModel viewModel)
        {
            this.viewModel = viewModel;
        }

		public event EventHandler CanExecuteChanged;

		public Boolean CanExecute(Object parameter)
		{
			return true;
		}
        
		public void Execute(Object parameter)
		{            
			String parameterString = parameter as String;
			if(parameterString == null)
				throw new Exception();

            if(parameterString.Equals("prev"))
            {
                viewModel.UpdateDisplay(parameter);
            }
            else if(parameterString.Equals("next"))
            {
                viewModel.UpdateDisplay(parameter);
            }
		}
	}
}
