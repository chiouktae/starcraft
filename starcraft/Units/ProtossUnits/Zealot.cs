namespace starcraft.Units.ProtossUnits
{
    class Zealot : ProtossUnit
    {
        public Zealot()
        {
            HP = 100;
            Shield = 100;
        }

        protected override string UnitName
        {
            get
            {
                return "Zealot";
            }
        }
    }
}
