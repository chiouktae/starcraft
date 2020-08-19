namespace starcraft.Units.TerranUnits
{
    class Marine : TerranUnit, ISpecialUnit
    {
        protected override string UnitName
        {
            get
            {
                return "Marine";
            }
        }

        public void UseSpecialAbility()
        {
            UseSteamPack();
        }

        public void UseSteamPack()
        {
            System.Console.WriteLine("스팀팩");
        }
    }
}
