using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace CallCalc
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Favorit : ContentPage
    {
        public Favorit()
        {
            InitializeComponent();
            Title = "Избранное";
        }
    }
}