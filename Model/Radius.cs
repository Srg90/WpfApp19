using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp19.Model
{
    static class Radius
    {
        public static double Circumference(double r) => 2 * Math.PI * r;
        public static double Area(double r) => Math.PI * Math.Pow(r, 2);
        public static double SphereVolume(double r) => 4 * Math.PI * Math.Pow(r, 3) / 3;
        
    }
}
