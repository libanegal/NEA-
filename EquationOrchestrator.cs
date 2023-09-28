using protoytpe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoytpe
{
    public class EquationOrchestrator
    {
        private readonly ICubic _Cubic;
        private readonly IQuadratic _Quadratic;
        private readonly IMatrixMultiplication _matrixMultiplication;
        private readonly IMatrixDivision _matrixDivision;
        private readonly IMatrixAddition _matrixAddition;
        private readonly IMatrixSubtraction _matrixSubtraction;
        public EquationOrchestrator(ICubic cubic, IQuadratic quadratic, IMatrixMultiplication matrixMultiplication,IMatrixDivision matrixDivision, IMatrixAddition matrixAddition, IMatrixSubtraction matrixSubtraction   )
        {
            _Cubic = cubic;
            _Quadratic = quadratic;
            _matrixMultiplication = matrixMultiplication;
            _matrixDivision = matrixDivision;
            _matrixAddition = matrixAddition;
            _matrixSubtraction = matrixSubtraction;
        }

        public void Equationrchestrator()
        {
            string MenuChoice; Console.WriteLine("Enter what option you would like:\n1-Polynomials\n2-Matrices\n3 to exit");
            MenuChoice = Console.ReadLine();
            do
            {
                
                if (MenuChoice == "1")
                {
                    string CubicorQuadratic; Console.WriteLine("Enter 1 for Cubic\n2 for quadratic");
                    CubicorQuadratic = Console.ReadLine();
                    if (CubicorQuadratic == "1")
                    {
                         _Cubic.SolveCubicEquation();
                    }
                    else if (CubicorQuadratic == "2")
                    {
                         _Quadratic.quadratic();
                    }
                }
                else if (MenuChoice == "2")
                {
                    string matrices; Console.WriteLine("Enter 1 for Matrix addition \n2 for matrix subtraction \n3 for matrix division \n4 for matrix multiplication");
                    matrices = Console.ReadLine();
                    
                    if (matrices == "1")
                    {
                        var matrixAddition = _matrixAddition.Matrixaddition();
                    }
                    else if (matrices == "2")
                    {
                        var matrixSubtraction = _matrixSubtraction.Matrixsubtraction();
                    }
                    else if (matrices == "3")
                    {
                        var matrixDivision = _matrixDivision.Matrixdivision();
                    }
                    else if (matrices == "4")
                    {
                        var matrixmultiplication = _matrixMultiplication.Matrixmultiplication();
                    }
                    

                }
                _ = MenuChoice; Console.WriteLine("Enter what option you would like:\n1-Polynomials\n2-Matrices\n3 to exit");
                MenuChoice = Console.ReadLine();
            } while (MenuChoice != "3");
        }
        
    }
}
