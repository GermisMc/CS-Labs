using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeopleSport
{
    internal class Sportsman : People
    {
        internal string sport;
        internal int NumberContest;
        internal Boolean IsChampion;

        internal Sportsman(int age, int rise, string body, string SocialRole, Boolean IsSelf, string sport, int NumberContest, Boolean IsChampion)
    {
        this.age = age;
        this.rise = rise;
        this.body = body;
        this.SocialRole = SocialRole;
        this.IsSelf = IsSelf;
        this.IsChampion = IsChampion;
        this.sport = sport;
        this.NumberContest = NumberContest;
    }
    }
}
