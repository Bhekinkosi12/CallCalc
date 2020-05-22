using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CallCalc.Dishes
{
    public class FriedEgg : BindableObject
    {
        public static readonly BindableProperty DishWeightProperty = BindableProperty.Create("DishWeight", typeof(double), typeof(FriedEgg), 100.0);

        public double DishWeight
        {
            get
            {
                return (double)GetValue(DishWeightProperty);
            }
            set
            {
                SetValue(DishWeightProperty, value);
            }
        }
        public string TCall;
        public FriedEgg (double w)
        {
            DishWeight = w;
        }
        DishComponent egg = new Egg();
        DishComponent oil = new SunflowerOil();
        public void TotalCallories()
        {
            egg.ChangeWeight(DishWeight * 0.95);
            oil.ChangeWeight(DishWeight * 0.05);
            double e = egg.TotalCallories();
            double o = oil.TotalCallories();
            e += o;
            TCall = e.ToString();
        }
    }
}
