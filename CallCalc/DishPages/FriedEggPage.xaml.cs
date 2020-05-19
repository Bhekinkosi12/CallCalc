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
            Title = " ";
            Entry input = new Entry();
            FriedEgg fegg = new FriedEgg(100);
            Label output = new Label
            {
                FontSize = Device.GetNamedSize(NamedSize.Large, typeof(Label))
            };

            int i = 0;

            fegg.BindingContext = input;
            fegg.SetBinding(FriedEgg.WeightProerty, "Text");
            input.BindingContext = fegg;
            input.SetBinding(Entry.TextProperty, "dishWeight");

            input.TextChanged += Input_TextChanged;

            fegg.BindingContext = output;
            fegg.SetBinding(FriedEgg.tCallProperty, "Text");
            output.BindingContext = fegg;
            output.SetBinding(Label.TextProperty, "tCall");

            StackLayout stackLayout = new StackLayout
            {
                Children = { input, output }
            };
            Content = stackLayout;
        }

        public void Input_TextChanged(object sender, TextChangedEventArgs e)
        {
            Entry input = (Entry)sender;                        
        }
    }
}