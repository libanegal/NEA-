using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.Authentication.ExtendedProtection;
using Microsoft.Extensions.DependencyInjection;
using protoytpe.Interfaces;
using protoytpe.Matrices;

namespace protoytpe
{
    public class Program
    {
        static void Main(string[] args)
        {
            var service = new ServiceCollection();
            service.AddSingleton<ICubic, Cubic>();
            service.AddSingleton<IQuadratic, Quadratic>();
            service.AddScoped<IMatrixMultiplication, MatrixMultiplication>();
            service.AddTransient<IMatrixDivision, MatrixDivision>();
            service.AddScoped<IMatrixAddition, MatrixAddition>();
            service.AddScoped<IMatrixSubtraction, MatrixSubtraction>();


            var serviceProvider = service.BuildServiceProvider();

            var cubic = serviceProvider.GetRequiredService<ICubic>();
            var Quadratic = serviceProvider.GetRequiredService<IQuadratic>();
            var matrixmultiplication = serviceProvider.GetRequiredService<IMatrixMultiplication>();
            var matrixDivision = serviceProvider.GetRequiredService<IMatrixDivision>();
            var matrixAddition = serviceProvider.GetRequiredService<IMatrixAddition>();
            var matrixSubtraction = serviceProvider.GetRequiredService<IMatrixSubtraction>();

            var run = new EquationOrchestrator(cubic, Quadratic, matrixmultiplication, matrixDivision,matrixAddition, matrixSubtraction);       
            run.Equationrchestrator();
            
        }


    }
}

