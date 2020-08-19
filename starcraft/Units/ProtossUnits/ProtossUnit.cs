namespace starcraft.Units.ProtossUnits
{
    abstract class ProtossUnit : Unit
    {
        public int Shield { get; protected set; }

        public override void TakeDamage(int damage)
        {
            while (damage > 0 && Shield > 0)
            {
                damage--;
                Shield--;
            }

            base.TakeDamage(damage); // super
        }

        public override string ToString()
        {
            return $"I am a {UnitName} and my HP is {HP} and my shield is {Shield}";
        }
    }
}
