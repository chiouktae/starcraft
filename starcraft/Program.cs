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
            m1._Recall += Marine_Recall;
            m1._Recall += Marine_Recall_Effect;
            m1.TakeDamage(30);
            m1.Move(1, 1);
            Console.WriteLine(m1);
            UseSpecialAbility((ISpecialUnit)m1, 3);

            Unit f1 = new Firebat();
            f1._Recall += Firebat_Recall;
            f1._Recall += Firebat_Recall_Effect;
            f1.TakeDamage(20);
            f1.Move(10, 10);
            Console.WriteLine(f1);

            Unit z1 = new Zealot();
            z1.TakeDamage(150);
            z1.Move(100, 100);
            Console.WriteLine(z1);

            Arbirter a1 = new Arbirter();
            a1.TakeDamage(10);
            a1.Move(5, 5);
            Console.WriteLine(a1);
            a1.Recall(10, 10);
            a1.Recall(10, 10);
            a1.Recall(10, 10);
        }

        private static void Marine_Recall_Effect(object sender, Unit._RecallEventArgs e)
        {
            Console.WriteLine($"마린에 effect가 표기됨");
        }

        private static void Firebat_Recall_Effect(object sender, Unit._RecallEventArgs e)
        {
            Console.WriteLine($"파이어뱃에 effect가 표기됨");
        }

        private static void Firebat_Recall(object sender, Unit._RecallEventArgs e)
        {
            Console.WriteLine($"파이어뱃이{e.X},{e.Y}로 이동함");
        }

        private static void Marine_Recall(object sender, Arbirter._RecallEventArgs e)
        {
            Console.WriteLine($"마린이{e.X},{e.Y}로 이동함");
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
