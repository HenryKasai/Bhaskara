using System;

namespace Bhaskara
{
    class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Insira os valores de a, b e c.");
            Console.Write("a = ");
            bool abool = Double.TryParse(Console.ReadLine(), out a);
            Console.Write("b = ");
            bool bbool = Double.TryParse(Console.ReadLine(), out b);
            Console.Write("c = ");
            bool cbool = Double.TryParse(Console.ReadLine(), out c);

            if (!(abool && bbool && cbool)) 
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Valor inválido.");
                Console.ResetColor();
                Environment.Exit(-1);
            }
            else
            {
                if (a == 0)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("Não é uma equação de segundo grau.");
                    Console.ResetColor();
                    Environment.Exit(-1);
                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    double delta = Math.Pow(b, 2) - 4 * a * c;
                    if (delta < 0)
                    {
                        Console.WriteLine($"Delta = {delta}, portanto nessa equação não há raízes.");
                    }
                    else
                    {
                        double resultado1 = (-b + Math.Sqrt(delta)) / 2 * a;
                        double resultado2 = (-b - Math.Sqrt(delta)) / 2 * a;
                        Console.WriteLine($"x1 = {resultado1:N2} e x2 = {resultado2:N2}");
                    }
                    Console.ResetColor();
                }
            }

        }
    }
}
