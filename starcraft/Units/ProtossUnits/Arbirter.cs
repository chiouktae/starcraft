using System;

namespace starcraft.Units.ProtossUnits
{
    class Arbirter : ProtossUnit, ISpecialUnit
    {
        public Arbirter()
        {
            HP = 100;
            Shield = 150;
            MP = 250;
            X = 0;
            Y = 0;
        }

        protected override string UnitName => "Arbirter";

        public void UseSpecialAbility()
        {
            foreach (Unit unit in LocationSearch(10, 10, 10))
            {
                unit.Move(X, Y);
            }
            Console.WriteLine($"순간이동!X={X},Y={Y}");
        }
    }
}
