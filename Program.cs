using System;

namespace GrausFC
{
    class Program
    {
        static void Main(string[] args)
        {
            string grauF1;
            double grauF2;
            double grauC1;
            
            Console.Clear();
        
            Console.Write("Informe a temperatura em °F:");
            grauF1 = Console.ReadLine();
            
            Console.WriteLine();
            grauF2 = Convert.ToDouble(grauF1);

            grauC1 = (grauF2 - 32) / 1.8;

            Console.WriteLine($"°F convetido em °C: {grauC1:n2} ");




        }
    }
}
