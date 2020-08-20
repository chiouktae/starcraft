using System;

namespace starcraft.Units.ProtossUnits
{
    class Arbirter : ProtossUnit
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

        public void Recall(int x,int y)
        {
            foreach (Unit unit in UnitManager.Instance.GetUnitsInRange(10, 10, 10))
            {
                unit.Move(X, Y);
                Console.WriteLine($"{unit.GetUnitName()}순간이동!X={X},Y={Y}");
            }
        }

        
    }
}
