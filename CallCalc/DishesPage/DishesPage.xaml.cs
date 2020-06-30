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
        public ObservableCollection<>;
        public DishesPage()
        {
            InitializeComponent();
        }
        private void picker_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
