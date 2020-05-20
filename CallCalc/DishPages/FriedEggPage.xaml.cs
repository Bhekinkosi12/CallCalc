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
        public FriedEgg fegg = new FriedEgg(100);
        public FriedEggPage()
        {
            InitializeComponent();
            Title = "";

            Slider input = new Slider {Minimum = 0, Maximum = 500, Value = 200 };
            Label output = new Label();
            Label header = new Label();

            Binding headerBinding = new Binding { Source = input, Path = "Value" };
            header.SetBinding(Label.TextProperty, headerBinding);

            Binding inputBinding = new Binding {Source = input, Path = "Value"};
            fegg.SetBinding(FriedEgg.WeightProerty, inputBinding);

            Binding outputBinding = new Binding { Source = fegg, Path = "TCallProperty"};
            output.SetBinding(Label.TextProperty, outputBinding);

            input.ValueChanged += Input_ValueChanged;

            StackLayout stackLayout = new StackLayout
            {
                Children = { header, input, output }
            };
            Content = stackLayout;
        }

        private void Input_ValueChanged(object sender, ValueChangedEventArgs e)
        {
            fegg.TotalCallories();
        }
    }
}