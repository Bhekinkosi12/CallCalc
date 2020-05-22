using CallCalc.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;

namespace CallCalc
{
    public class CalculateCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;
        DishViewModel viewModel;
        public CalculateCommand(DishViewModel vm)
        {
            viewModel = vm;
        }

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            viewModel.TCallcomand();
        }
    }
}
