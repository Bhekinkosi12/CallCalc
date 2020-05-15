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
        public int weight;
        public double TotalCallories(double tcall)
        {
            _ = (protein * 4 + fat * 9 + carbohydrates * 4) / 100 * weight;
            return tcall;
        }
        public double DefaultCallories(double call)
        {
            _ = protein * 4 + fat * 9 + carbohydrates * 4;
            return call;
        }
    }
}
