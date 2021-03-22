using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Xamarin.Forms;

namespace CallCalc.Dishes
{
    public class FriedEgg
    {
        public double DishWeight { get; set; }
        public FriedEgg (double w)
        {
            DishWeight = w;
        }
        DishComponent egg = new Egg();
        DishComponent oil = new SunflowerOil();
        public double TotalCallories()
        {
            egg.ChangeWeight(DishWeight * 0.95);
            oil.ChangeWeight(DishWeight * 0.05);
            double e = egg.TotalCallories();
            double o = oil.TotalCallories();
            e += o;
            return e;
            
        }
    }
}
