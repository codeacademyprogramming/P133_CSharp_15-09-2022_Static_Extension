using System;
using System.Collections.Generic;
using System.Text;

namespace ClassWork.Models
{
    class Velosiped : Vheicle
    {
        public Velosiped(int year) : base(year)
        {

        }

        public override void Drive(double km)
        {
            Millage += km;
        }
    }
}
