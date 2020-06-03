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
        private double TCall;

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
            get { return TCall; }
            set
            {
                if (TCall != value)
                {
                    TCall = value;
                    OnPropertyChanged("TotallCall");
                }
            }
        }
        public double TCallcommand()
        {
            TotallCall = fegg.TotalCallories();
            return TotallCall;
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
