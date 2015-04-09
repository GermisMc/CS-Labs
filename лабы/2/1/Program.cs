using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
{
    class Program
    {
        static void Main(string[] args)
        {
            // general format
            DateTime DayTime = DateTime.Now;
            string day = DayTime.ToString();
            Console.WriteLine(day);
            Console.WriteLine();
            // format D
            string dayfD = DayTime.ToString("D");
            Console.WriteLine(dayfD);
            Console.WriteLine();


            for (int i = 0; i < 10; i++)
            {
                int numb = 0;

                int count = day.IndexOf(i.ToString());
                while (count != -1)
                {
                    numb++;
                    day = day.Remove(count, 1);
                    count = day.IndexOf(i.ToString());

                }
                Console.WriteLine("количество " + i + " = " + numb);
            }

            Console.Read();
        }
    }
}
