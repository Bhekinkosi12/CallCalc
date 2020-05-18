using System;
using System.Collections.Generic;
using System.Text;

namespace CallCalc.Dishes
{
    class FriedEgg
    {
        public int dishWeight;
        public FriedEgg (int w)
        {
            dishWeight = w;
        }             
        DishComponent egg = new Egg();
        DishComponent oil = new SunflowerOil();
        public double TotalCallories()
        {
            double e;
            double o;
            egg.ChangeWeight(dishWeight * 0.95);
            oil.ChangeWeight(dishWeight * 0.05);
            e = egg.TotalCallories();
            o = oil.TotalCallories();
            e += o;
            return e;
        }
    }
}
