using System;
using System.Collections.Generic;
using System.Text;

namespace UsingAbstract
{
    class IronBonesDefence : SpecialDefence
    {
        public override int ReduceDamage(int Damage)
        {
            return 10;
        }
    }
}
