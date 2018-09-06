using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInterface
{
    class IronBonesDefence : ISpecialDefence
    {
        public int ReduceDamage(int Damage)
        {
            return 10;
        }
    }
}
