using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using System.Collections.Generic;

namespace CallCalc.DishesPage
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class DishesPage : ContentPage
    {
        List<DishComponent> list = new List<DishComponent>();
        public DishesPage()
        {
            InitializeComponent();
            list.Add(new Egg());
            list.Add(new Chicken());
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
        private async void consumedList_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            bool result = await DisplayAlert("Подтвердите действие", "Удалить элемент?", "Да", "Нет");
            if(result == true)
            {
                var consumed = consumedList.SelectedItem as Consumed;
                await App.Database.DeleteItemAsync(consumed);
            }
            await App.Database.GetItemsAsync();
        }

        private void Button_Clicked(object sender, EventArgs e)
        {
            
        }
    }
}
