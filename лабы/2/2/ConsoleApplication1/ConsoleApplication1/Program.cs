using System;
using System.Globalization;
using System.Threading;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите язык в формате 'fr-FR'");
            string language = Console.ReadLine();
            Thread.CurrentThread.CurrentCulture = CultureInfo.CreateSpecificCulture(language);
            for (int CurentMonth = 1; CurentMonth <= 12; CurentMonth++)
            {
                DateTime month = new DateTime(2015, CurentMonth, 12);
                Console.WriteLine(month.ToString("MMMM"));
            }
            Console.Read();
        }
    }
}
