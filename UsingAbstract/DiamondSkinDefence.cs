using System;
using System.Collections.Generic;
using System.Text;

namespace UsingAbstract
{
    class DiamondSkinDefence : SpecialDefence
    {
        public override int ReduceDamage(int Damage)
        {
            return 20;
        }
    }
}
