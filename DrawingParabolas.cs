using System;
using System.Drawing;
using Color = System.Windows.Media.Color;

public class QuadraticEquationGraph
{
    public static int  DrawingEquations()
    {
        int width = 800;    // Width of the graph
        int height = 600;   // Height of the graph
        Bitmap graph = new Bitmap(width, height);

        using (Graphics g = Graphics.FromImage(graph))
        {
            g.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;
            g.Clear(Color.White);

            // Draw axes
            g.DrawLine(Pens.Black, 0, height / 2, width, height / 2);   // X-axis
            g.DrawLine(Pens.Black, width / 2, 0, width / 2, height);   // Y-axis

            // Draw quadratic equation graph
            float scale = 20;   // Scale factor for the graph
            float a = 2;        // Quadratic coefficient
            float b = -3;       // Linear coefficient
            float c = 1;        // Constant term

            for (int x = -width / 2; x <= width / 2; x++)
            {
                float y = (a * x * x) + (b * x) + c;
                int pixelX = width / 2 + (int)(x * scale);
                int pixelY = height / 2 - (int)(y * scale);
                graph.SetPixel(pixelX, pixelY, Color.Black);
            }

            // Calculate and output the roots
            float discriminant = (b * b) - (4 * a * c);
            if (discriminant >= 0)
            {
                float root1 = (-b + (float)Math.Sqrt(discriminant)) / (2 * a);
                float root2 = (-b - (float)Math.Sqrt(discriminant)) / (2 * a);

                Console.WriteLine("Root 1: " + root1);
                Console.WriteLine("Root 2: " + root2);
            }
            else
            {
                Console.WriteLine("No real roots exist.");
            }
        }

        // Save the graph to a file
        graph.Save("quadratic_equation_graph.png");
        Console.WriteLine("Graph saved to quadratic_equation_graph.png.");
        return 23;
    }
}