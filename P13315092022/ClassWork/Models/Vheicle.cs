using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    abstract class Vheicle
    {
        public string Color;
        public string Brand;
        public int Year;
        public double Millage;

        public Vheicle(int year)
        {
            Year = year;
        }

        public virtual string ShowInfo()
        {
            return $"Brand: {Brand}\nColor: {Color}\nMillage: {Millage}\nYear: {Year}";
        }

        public abstract void Drive(double km);
    }
}
