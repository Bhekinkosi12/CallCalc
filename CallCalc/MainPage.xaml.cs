using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using CallCalc.DishesPage;

namespace CallCalc
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private async void OnDayRationClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new DishPlan());
        }
        private async void DishListClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new DishesPage.DishesPage());
        }
        private async void FavoritClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new Favorit());
        }
        private async void DailySummClicked(object sender, System.EventArgs e)
        {
            Button button = (Button)sender;
            await Navigation.PushAsync(new DailySumm());
        }
    }
}
