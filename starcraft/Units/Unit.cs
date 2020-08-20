using System;

namespace starcraft.Units
{
    abstract class Unit
    {
        public int X { get; set; } // auto property

        private int _y;

        public int Y
        {
            get
            {
                return _y;
            }
            set
            {
                _y = value;
            }
        }

        public void Move(int x, int y)
        {
            X = x;
            Y = y;
        }
        

        public Unit()
        {
            HP = 50;
            MP = 250;
        }

        public int HP { get; protected set; }

        public virtual void TakeDamage(int damage)
        {
            while (damage > 0 && HP > 0)
            {
                damage--;
                HP--;
            }
        }

        public int MP { get; protected set; }

        public virtual void UseMagicPower(int skillmana)
        {
            while (skillmana > 0 && MP > 0)
            {
                skillmana--;
                MP--;
            }
        }

        public override string ToString()
        {
            return $"I am a {UnitName} and my HP is {HP}";
        }

        protected abstract string UnitName
        {
            get;
        }

        public string GetUnitName()
        {
            return UnitName;
        }

        /// <summary>
        /// 특정 좌표로부터의 거리를 구한다.
        /// </summary>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <returns></returns>
        public double GetDistanceFrom(int x, int y)
        {
            return (double)Math.Sqrt(Math.Pow(X - x, 2) + Math.Pow(Y - y, 2));
        }
    }
}
