using System;
using System.Collections.Generic;
using System.Text;

namespace UsingInterface
{
    class DiamondSkinDefence : ISpecialDefence
    {
        public int ReduceDamage(int Damage)
        {
            return 20;
        }
    }
}
