using CallCalc.ViewModel;
using System;
using System.Collections.Generic;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

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
            return viewModel.DishWeight > 0;
        }

        public void Execute(object parameter)
        {
            if(CanExecute(parameter))
            {
                viewModel.TCallcommand();
            }
        }
    }
}
