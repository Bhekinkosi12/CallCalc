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
        Dictionary<string, DishComponent> dictionary = new Dictionary<string, DishComponent>();
        public DishesPage()
        {
            InitializeComponent();
            dictionary.Add("Яйцо", new Egg());
            dictionary.Add("Курица", new Chicken());
        }
        protected override async void OnAppearing()
        {
            await App.Database.CreateTable();
            consumedList.ItemsSource = await App.Database.GetItemsAsync();
            base.OnAppearing();
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
            if(picker.SelectedItem != null)
            {
                string name = picker.SelectedItem.ToString();
                List<object> storedConsumptionList = new List<object>
                {
                    App.Database.FindByName(name)
                };
                Consumed storedConsumption = new Consumed();
                
            }
        }
    }
}
