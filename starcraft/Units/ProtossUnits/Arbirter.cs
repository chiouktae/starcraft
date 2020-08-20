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
            Unit[] units = Unit.LocationSearch(10, 10, 10);
            //todo : 범위탐색후 해당유닛들을 아비터의 좌표로 이동
            foreach (Unit unit in units)
            Move(10, 20);
            Console.WriteLine($"순간이동!X={X},Y={Y}");
        }
    }
}
