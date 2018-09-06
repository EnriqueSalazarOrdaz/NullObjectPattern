using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutPattern
{
    class DiamondSkinDefence : ISpecialDefence
    {
        public int ReduceDamage(int Damage)
        {
            return 20;
        }
    }
}
