using CallCalc.Dishes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallCalc.DishPages
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class FriedEggPage : ContentPage
    {
        public FriedEggPage()
        {
            InitializeComponent();
        }

        private void EggWeightEntry_Completed(object sender, EventArgs e)
        {
            double c;           
            FriedEgg fegg = new FriedEgg(200);
            c = fegg.TotalCallories();
        }
    }
}