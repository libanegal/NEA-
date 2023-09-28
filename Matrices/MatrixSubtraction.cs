using protoytpe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoytpe
{
    public class MatrixSubtraction:IMatrixSubtraction
    {
        public int[,] Matrixsubtraction()
        {
            //Setting dimensions of both matrix
            int[,] matrix1 = new int[2, 2];
            int[,] matrix2 = new int[2, 2];
            //Populating first Matrix
            Console.WriteLine("You will enter values for your first matrix");
            for (int i = 0; i < matrix1.GetLength(0); i++)
            {
                for (int j = 0; j < matrix1.GetLength(1); j++)
                {
                    int value;
                    Console.WriteLine("Enter value: ");
                    value = int.Parse(Console.ReadLine());
                    matrix1[i, j] = value;
                }
            }
            Console.Clear();
            //Populating second matrix
            Console.WriteLine("You will enter values for your second matrix");
            for (int i = 0; i < matrix2.GetLength(0); i++)
            {
                for (int j = 0; j < matrix2.GetLength(1); j++)
                {
                    int value;
                    Console.WriteLine("Enter value: ");
                    value = int.Parse(Console.ReadLine());
                    matrix2[i, j] = value;
                }
            }

            //Setting dimensions of result matrix
            int[,] resultMatrix = new int[2, 2];
            //Subtracting matrices
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    resultMatrix[i, j] = matrix1[i, j] - matrix2[i, j];
                }
            }
            Console.Clear();
            //printing result
            Console.WriteLine("Result of adding your two matrices togther");
            Console.ReadLine();
            for (int i = 0; i < resultMatrix.GetLength(0); i++)
            {
                for (int j = 0; j < resultMatrix.GetLength(1); j++)
                {
                    //print single value 
                    Console.Write(resultMatrix[i, j]);
                }
                //print row
                Console.WriteLine();
            }
            return resultMatrix;

        }
    }
}
