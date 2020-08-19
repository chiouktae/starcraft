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
        }

        protected override string UnitName => "Arbirter";

        public void UseSpecialAbility()
        {
            Move(10, 20);
            Console.WriteLine($"순간이동!X={X},Y={Y}");
        }
    }
}
