using System;

namespace starcraft.Units.ProtossUnits
{
    class Arbirter : ProtossUnit
    {
        const int RecallRange = 10;
        const int RecallUsingMana = 150;
        public Arbirter()
        {
            HP = 100;
            Shield = 150;
            MP = 250;
        }

        protected override string UnitName => "Arbirter";

        public void Recall(int x,int y)
        {
            if (UseMagicPower(RecallUsingMana))
            {
                foreach (Unit unit in UnitManager.Instance.GetUnitsInRange(x, y, RecallRange))
                {
                    if (unit != this)
                    {
                        unit.Recalled(X, Y);
                    }
                }
            }
        }
    }
}
