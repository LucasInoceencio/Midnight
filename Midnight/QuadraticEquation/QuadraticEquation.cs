using System;

namespace Midnight
{
    public static class QuadraticEquation
    {
        public static Tuple<double, double> FindRoots(double a, double b, double c)
        {
            double delta = (b * b) - (4 * a * c);
            double raiz = Math.Sqrt(delta);
            var x1 = ((-(b)) + raiz) / (2 * a);
            var x2 = ((-(b)) - raiz) / (2 * a);
            return new Tuple<double, double>(x1, x2);
        }
    }
}
