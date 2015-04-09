using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        static void Main(string[] args)
        {
            int result;

            Console.WriteLine("Добро пожаловать в 'очко'");
            Random point = new Random();
            int card = point.Next(2, 11);
            int next_card = point.Next(2, 11);
            Console.WriteLine("Ваши начальные карты "+ card + " " + next_card);
            result = card + next_card;
            Console.WriteLine("Ваш счет: "+ result +" Чтобы добрать нажимайте 'Space' открыться 'Esc'");
            ConsoleKeyInfo key = Console.ReadKey();
            if (key.Key == ConsoleKey.Spacebar)
            {
                while (result < 22)
                {
                    result = result + point.Next(2, 11);
                    Console.WriteLine("Ваш счет: " + result);
                    if (result > 21) Console.WriteLine("Перебор, Вы проиграли!");
                    if (result == 21)
                    {
                        Console.WriteLine("Вы выиграли!");
                        Console.ReadLine();
                        return;
                    }
                    ConsoleKeyInfo keyp = Console.ReadKey();
                    if (keyp.Key == ConsoleKey.Escape & result < 22)
                    {
                        Console.WriteLine("Вы выиграли, Ваш счет: " + result);
                        Console.ReadLine();
                        return;
                    }
                }
            }
            else
            {
                if (key.Key == ConsoleKey.Escape & result < 22)
                {
                    Console.WriteLine("Вы выиграли, Ваш счет: " + result);
                    Console.ReadLine();
                    return;
                }
            }

            Console.Read();
        }
    }
}
