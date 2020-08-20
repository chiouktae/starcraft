using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using starcraft.Units;
using starcraft.Units.ProtossUnits;
using starcraft.Units.TerranUnits;

namespace starcraft
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Unit> units = new List<Unit>();

            Unit m1 = new Marine();
            units.Add(m1);
            m1.TakeDamage(30);
            m1.Move(1, 1);
            Console.WriteLine(m1);

            Unit f1 = new Firebat();
            units.Add(f1);
            f1.TakeDamage(20);
            f1.Move(10, 10);
            Console.WriteLine(f1);

            Unit z1 = new Zealot();
            units.Add(z1);
            z1.TakeDamage(150);
            z1.Move(100, 100);
            Console.WriteLine(z1);

            Unit a1 = new Arbirter();
            units.Add(a1);
            a1.TakeDamage(10);
            a1.Move(5, 5);
            Console.WriteLine(a1);
            UseSpecialAbility((ISpecialUnit)a1,units);
        }
       
        private static void LetDance(Unit unit) // overloading
        {
            unit.Move(100, 100);
            unit.Move(1, 1);
        }
        static void UseSpecialAbility(ISpecialUnit unit, int n)
        {
            //for (int i = 0; i < n; i++)
            //{
            //    if (unit is Marine) // instanceof
            //        ((Marine)unit).UseSteamPack();
            //    if (unit is Ghost)
            //        ((Ghost)unit).Cloak();

            //    //Marine m = unit as Marine;
            //    //if (m != null)
            //    //    m.UseSteamPack();
            //}

            for (int i = 0; i < n; i++)
            {
                unit.UseSpecialAbility();
            }
        }
        static void UseSpecialAbility(ISpecialUnit unit ,object obj)
        {
            unit.UseSpecialAbility();
        }
    }
}
