using CallCalc.Dishes;
using System.ComponentModel;
using System.Windows.Input;

namespace CallCalc.ViewModel
{
    public class DishViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public FriedEgg fegg;
        public ICommand Calculate { get; }

        public DishViewModel()
        {
            fegg = new FriedEgg(100.0);
            Calculate = new CalculateCommand(this);
        }
        public double DishWeight
        {
            get { return fegg.DishWeight; }
            set
            {
                if (fegg.DishWeight != value)
                {
                    fegg.DishWeight = value;
                    OnPropertyChanged("DishWeight");
                }
            }
        }
        public double TotallCall
        {
            get { return fegg.TCall; }
            set
            {
                if (fegg.TCall != value)
                {
                    fegg.TCall = value;
                    OnPropertyChanged("TCall");
                }
            }
        }
        public double TCallcommand()
        {
            return fegg.TotalCallories();
        }
        private void OnPropertyChanged(string propName)
        {
            if(PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
