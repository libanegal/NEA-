using protoytpe.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace protoytpe
{
    public class MatrixMultiplication: IMatrixMultiplication
    {
        public int[,] Matrixmultiplication()
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
            
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {


                    resultMatrix[i,j]=0;
                     for (int k = 0; k < 2; k++)
                     {
                        resultMatrix[i, j] += matrix1[i, k] * matrix2[k, j];
                     }
                 }
            }
            for (int i = 0; i < 2; i++)
            {
                for (int j = 0; j < 2; j++)
                {
                    Console.Write(resultMatrix[i, j]+"\t");
                }
                Console.WriteLine();
            }
            return resultMatrix;
        }
    }
}
