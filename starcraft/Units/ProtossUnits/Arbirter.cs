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
            System.Console.WriteLine("으아아 미안해요");
        }
    }
}
