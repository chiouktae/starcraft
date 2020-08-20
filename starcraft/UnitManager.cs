using starcraft.Units;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft
{
    class UnitManager
    {
        #region singleton
        private UnitManager()
        {

        }

        private static UnitManager _instance;

        public static UnitManager Instance
        {
            get 
            {
                if (_instance == null)
                    _instance = new UnitManager();
                return _instance;
            }
            
        }
        #endregion

        List<Unit> units = new List<Unit>();
        
        public void Add(Unit unit)
        {
            units.Add(unit);
        }

        //todo : 범위탐색 구현
        public List<Unit> GetUnitsInRange(int x, int y, int r)
        {
            List<Unit> InRangeUnits = new List<Unit>();
            foreach(Unit unit in units)
            {
                if (unit.GetDistanceFrom(x, y) <= r)
                    InRangeUnits.Add(unit);
            }
            return InRangeUnits;
        }
    }
}
