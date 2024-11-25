using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using biblio;

namespace bibka
{
    internal class Program
    {
        static void Main(string[] args)
        {
            bibi myLib = new bibi();

            myLib.MyVoidMethod1();
            myLib.MyVoidMethod2("Hello from Рашка!");

            int sum = myLib.MyIntMethod(5, 5);
            Console.WriteLine($"сумма: {sum}");

            string combinedString = myLib.MyStringMethod("Привет", "Вадик");
            Console.WriteLine($"Приветствие: {combinedString}");

            double result = myLib.MyDoubleMethod(10.0);
            Console.WriteLine($"Результатик: {result}");

            Console.ReadKey();
        }
    }
}
