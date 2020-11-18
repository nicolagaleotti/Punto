using System;
using System.Collections.Generic;
using System.Text;

namespace Punto
{
    public class Punto3 : Punto2
    {
        public double Z { get; set; }

        public Punto3(double x, double y, double z) : base(x, y)
        {
            Z = z;
        }
    }
}
