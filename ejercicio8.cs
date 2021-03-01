using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            double prom = 0;
            int lower = 0, taller = 0;
            double[] heights = new double[5];
            Console.WriteLine("Introducir cinco alturas: ");
            for (int i = 0; i < heights.Length; i++)
            {
                heights[i] = double.Parse(Console.ReadLine());
                prom = prom + heights[i];
            }
            prom = prom / heights.Length;
            for (int k = 0; k < heights.Length; k++)
            {
                if (heights[k] > prom) { taller++; }
                else { lower++; }
            }
            Console.Write("Alturas: ");
            for (int h = 0; h < heights.Length; h++) { Console.Write($" {heights[h]},"); }
            Console.WriteLine();
            Console.WriteLine($"Promedio: {prom}.\nPersonas más altas: {taller}.\nPersonas más bajas: {lower}.");
        }
    }
}
