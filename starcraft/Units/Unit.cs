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
        public void Recalled(int x, int y)
        {
            X = x;
            Y = y;
            On_Recall(X, Y);
        }
        

        public Unit()
        {
            HP = 50;
            MP = 0;
            UnitManager.Instance.Add(this);
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

        public virtual bool UseMagicPower(int skillmana)
        {
            if(MP >= skillmana)
            {
                MP -= skillmana;
                return true;
            }
            else
            {
                Console.WriteLine("No Mana");
                return false;
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



        #region _Recall event things for C# 3.0
        public event EventHandler<_RecallEventArgs> _Recall;

        protected virtual void On_Recall(_RecallEventArgs e)
        {
            if (_Recall != null)
                _Recall(this, e);
        }

        private _RecallEventArgs On_Recall(int x, int y)
        {
            _RecallEventArgs args = new _RecallEventArgs(x, y);
            On_Recall(args);

            return args;
        }

        private _RecallEventArgs On_RecallForOut()
        {
            _RecallEventArgs args = new _RecallEventArgs();
            On_Recall(args);

            return args;
        }

        public class _RecallEventArgs : EventArgs
        {
            public int X { get; set; }
            public int Y { get; set; }

            public _RecallEventArgs()
            {
            }

            public _RecallEventArgs(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
        #endregion
    }
}
