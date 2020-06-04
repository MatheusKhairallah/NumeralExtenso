using System;
using Humanizer;
namespace NumeralExtenso
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Escreva qualquer número e te darei ele em extenso.");
            Console.Write("Digíte o número: ");
            int numero=Convert.ToInt32(Console.ReadLine());
            string numero2=numero.ToWords();
            Console.Clear();
            Console.WriteLine($"Seu número por extenso é= {numero2}");
        }
    }
}
