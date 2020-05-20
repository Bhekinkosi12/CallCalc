using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CallCalc.Dishes
{
    public class FriedEgg : BindableObject
    {
        public static readonly BindableProperty WeightProerty = BindableProperty.Create("DishWeight", typeof(double), typeof(FriedEgg), 100.0);
        public double DishWeight
        {
            get { return (double)GetValue(WeightProerty); }
            set { SetValue(WeightProerty, value); }
        }


        public static readonly BindableProperty TCallProperty = BindableProperty.Create("TCall", typeof(string), typeof(FriedEgg), "100.0");
        public string TCall
        {
            get { return (string)GetValue(TCallProperty); }
            set { SetValue(TCallProperty, value); }
        }


        public FriedEgg (double w)
        {
            DishWeight = w;
        }
        public DishComponent egg = new Egg();
        public DishComponent oil = new SunflowerOil();
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
