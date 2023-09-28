using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoytpe
{
    public class Quadratic:IQuadratic
    {
        public void quadratic()
        {
            Console.WriteLine("Quadratic Solver");

            Console.WriteLine("\n");
            Console.WriteLine("You must enter a real equation as imaginary equations are not in the A-level syllabus and not supported by this calculator.");

            Console.WriteLine("a: ");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("b: ");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("c: ");
            double c = double.Parse(Console.ReadLine());
           
            double discriminant = Math.Sqrt(Math.Pow(b, 2) - 4 * (a) * (c));

            bool real1 = double.IsNaN(discriminant);
            if (real1)
            {
                Console.WriteLine("The equation you have inputted has no real roots");
            }
            else
            {
                double Posroot = (-b + discriminant) / 2 * a;
                double negRoot = (-b - discriminant) / 2 * a;
                Console.WriteLine("roots are " + Posroot + " and " + negRoot);
            }
            Console.ReadKey();
           
        }
    }
}
