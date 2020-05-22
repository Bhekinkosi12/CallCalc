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
        public string TotallCall => fegg.TCall;
        public void TCallcomand()
        {
            fegg.TotalCallories();
        }

        private void OnPropertyChanged(string propName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
        }
    }
}
