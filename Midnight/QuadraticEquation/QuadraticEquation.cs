using System;

namespace Midnight
{
    public static class QuadraticEquation
    {
        #region Description problem

        // Link: https://www.testdome.com/questions/c-sharp/quadratic-equation/38499?visibility=1&skillId=18

        // Level: Easy

        // Implement the FindRoots function to find the roots of the quadratic equation: ax2 + bx + c = 0.
        // If the equation has only one solution, the function should return that solution as both elements of the tuple.
        // The equation will always have at least one solution.

        // For example, the roots of the equation 2x2 + 10x + 8 = 0 are -1 and -4.

        #endregion

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
