using System;
using System.Collections.Generic;
using System.Text;

namespace CallCalc
{
    public class DishComponent
    {
        public double protein;
        public double fat;
        public double carbohydrates;
        public double weight = 100;
        public void ChangeWeight(double w)
        {
            weight = w;
        }
        public double TotalCallories()
        {
            double tcall = (protein * 4 + fat * 9 + carbohydrates * 4) / 100 * weight;
            return tcall;
        }
        public double DefaultCallories(double call)
        {
            _ = protein * 4 + fat * 9 + carbohydrates * 4;
            return call;
        }
        public double TotalProtein(double tprot)
        {
            _ = protein / 100 * weight;
            return tprot;
        }
        public double TotalFat(double tfat)
        {
            _ = fat / 100 * weight;
            return tfat;
        }
        public double TotalCarbohydrates(double tcarb)
        {
            _ = carbohydrates / 100 * weight;
            return tcarb;
        }
    }
}
