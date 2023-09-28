using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoytpe
{
    public class Cubic:ICubic
    {
        public void SolveCubicEquation()
        {
            Console.WriteLine("Cubic Solver");
            Console.WriteLine("\n");
            Console.WriteLine("You must enter a real equation as imaginary equations are not in the A-level syllabus and not supported by this calculator.");
            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("c: ");

            double c = double.Parse(Console.ReadLine());
            Console.WriteLine("d: ");
            double d = double.Parse(Console.ReadLine());

            double p = (3 * a * c - b * b) / (3 * a * a);
            double q = (2 * b * b * b - 9 * a * b * c + 27 * a * a * d) / (27 * a * a * a);
            double delta = q * q / 4 + p * p * p / 27;

            double[] roots = new double[3];

            if (delta > 0)
            {
                double u = Math.Sqrt(-q / 2 + Math.Sqrt(delta));
                double v = Math.Sqrt(-q / 2 - Math.Sqrt(delta));

                roots[0] = u + v - b / (3 * a);
                roots[1] = -((u + v) / 2) - b / (3 * a);
                roots[2] = roots[1];
            }
            else if (delta == 0)
            {
                double u = Math.Sqrt(-q / 2);

                roots[0] = 2 * u - b / (3 * a);
                roots[1] = -u - b / (3 * a);
                roots[2] = roots[1];
            }
            else
            {
                double r = Math.Sqrt(-p * p * p / 27);
                double theta = Math.Acos(-q / (2 * r));
                double phi = theta / 3;
                double t1 = 2 * Math.Sqrt(-p / 3) * Math.Cos(phi);
                double t2 = 2 * Math.Sqrt(-p / 3) * Math.Cos(phi + 2 * Math.PI / 3);
                double t3 = 2 * Math.Sqrt(-p / 3) * Math.Cos(phi - 2 * Math.PI / 3);

                roots[0] = t1 - b / (3 * a);
                roots[1] = t2 - b / (3 * a);
                roots[2] = t3 - b / (3 * a);
            }
            foreach (var r in roots) 
            {
                Console.WriteLine("Root: " + r);
            }
            Console.Clear();
            
        }

       
    }
}
