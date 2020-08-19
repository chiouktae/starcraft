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
            Unit m1 = new Marine();
            m1.TakeDamage(30);
            Console.WriteLine(m1);

            Unit f1 = new Firebat();
            f1.TakeDamage(20);
            Console.WriteLine(f1);

            Unit z1 = new Zealot();
            z1.TakeDamage(150);
            Console.WriteLine(z1);

            Unit a1 = new Arbirter();
            a1.TakeDamage(150);
            Console.WriteLine(a1);
            UseSpecialAbility((ISpecialUnit)a1, 3);
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
    }
}
