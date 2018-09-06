using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInterface
{
    class NullDefence : ISpecialDefence
    {
        public int ReduceDamage(int Damage)
        {
            return 0;
        }
    }
}
