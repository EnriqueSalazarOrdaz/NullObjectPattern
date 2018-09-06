using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutPattern
{
    class IronBonesDefence : ISpecialDefence
    {
        public int ReduceDamage(int Damage)
        {
            return 10;
        }
    }
}
