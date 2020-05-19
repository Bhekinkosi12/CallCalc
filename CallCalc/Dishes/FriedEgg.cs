using System;
using System.Collections.Generic;
using System.Text;
using Xamarin.Forms;

namespace CallCalc.Dishes
{
    public class FriedEgg : BindableObject
    {
        public static readonly BindableProperty WeightProerty = BindableProperty.Create("dishWeight", typeof(double), typeof(FriedEgg), 100);
        public double dishWeight
        {
            get { return (double)GetValue(WeightProerty); }
            set { SetValue(WeightProerty, value); }
        }
        public static readonly BindableProperty tCallProperty = BindableProperty.Create("tCall", typeof(double), typeof(FriedEgg));
        public double tCall
        {
            get { return (double)GetValue(tCallProperty); }
            set { SetValue(tCallProperty, value); }
        }
        public FriedEgg (double w)
        {
            dishWeight = w;
        }
        DishComponent egg = new Egg();
        DishComponent oil = new SunflowerOil();
        public void TotalCallories()
        {
            egg.ChangeWeight(dishWeight * 0.95);
            oil.ChangeWeight(dishWeight * 0.05);
            double e = egg.TotalCallories();
            double o = oil.TotalCallories();
            e += o;
            tCall = e;
        }
    }
}
