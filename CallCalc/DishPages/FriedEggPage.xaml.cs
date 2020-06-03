using CallCalc.Dishes;
using CallCalc.ViewModel;
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
            DishViewModel vm = new DishViewModel();
            this.BindingContext = vm;
        }
    }
}