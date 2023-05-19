using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleMon
{
    internal class Arena
    {
        internal void Fight(ConsoleMon fighterA, ConsoleMon fighterB)
        {
            int aanval1 = Convert.ToInt32(fighterA.skills);
            fighterB.TakeDamage(aanval1);
            Thread.Sleep(1000);
            Console.WriteLine($"{fighterA.name} valt {fighterB.name} aan met een schade van {aanval1}!");
            Thread.Sleep(1000);
            // Vechter 2 valt vechter 1 aan
            int aanval2 = Convert.ToInt32(fighterB.skills);
            fighterA.TakeDamage(aanval2);
            Console.WriteLine($"{fighterB.name} valt {fighterA.name} aan met een schade van {aanval2}!");
            Thread.Sleep(1000);
            // Console-uitvoer van het resultaat van de aanvallen
            Console.WriteLine($"{fighterA.name} heeft nu {fighterA.health} HP.");
            Thread.Sleep(1000);
            Console.WriteLine($"{fighterB.name} heeft nu {fighterB.health} HP.");
        }
    }
}
