using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSport
{
    class Program
    {
        static void Main(string[] args)
        {
            Sportsman Nikita = new Sportsman(age: 18, rise: 181, body: "thin", IsSelf: false, SocialRole: "Student", sport: "swimming", IsChampion: false, NumberContest: 30);
            Console.WriteLine("Является чемпионом: {0}\nКоличетсво соревнований: {1}\nСамостоятельный: {2}\nВозраст: {3}\nТелосложение: {4}\nРост: {5}\nСоциальная роль: {6}\nВид Спорта: {7}",Nikita.IsChampion, Nikita.NumberContest, Nikita.IsSelf, Nikita.age, Nikita.body, Nikita.rise, Nikita.SocialRole, Nikita.sport);
            Console.Read();
        }
    }
}
