using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace part3
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rdnChar = new Random();
            Random count = new Random();

            string symbol;
            string empty = null;

            int i = count.Next(0, 4);


            while (i < 4)
            {
                int num = rdnChar.Next(0, 26);
                char let = (char)('a' + num);
                symbol = let.ToString();
                Console.Write(empty + symbol);
                i++;
            }
            Console.Read();
        }
    }
}
