using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallCalc.DishesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishesPage : ContentPage
    {
        public DishesPage()
        {
            InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            consumedList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
        }
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void consumedList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }
    }
}
