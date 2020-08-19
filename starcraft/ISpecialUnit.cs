using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace starcraft
{
    interface ISpecialUnit
    {
        // 추상클래스 : 추상 멤버가 한 개 이상 존재하는 클래스
        // 인터페이스 : 추상 멤버만 있는 클래스
        void UseSpecialAbility();
    }
}
