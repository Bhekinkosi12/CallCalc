using System;
using System.Collections.Generic;
using System.Text;

namespace CallCalc
{
    interface ICalculations
    {
        double DefaultCallories();
        double DefaultProtein();
        double DefaultFat();
        double DefaultCarbohydrates();
        double TotalCallories();
        double TotalProtein();
        double TotalFat();
        double TotalCarbohydrates();
    }
}