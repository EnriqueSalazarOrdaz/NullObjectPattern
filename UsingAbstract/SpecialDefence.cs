using System;
using System.Collections.Generic;
using System.Text;

namespace UsingAbstract
{
    abstract class SpecialDefence
    {
        public abstract int ReduceDamage(int Damage);

        public static SpecialDefence Null { get; } = new NullDefence();
        private class NullDefence : SpecialDefence
        {
            public override int ReduceDamage(int Damage)
            {
                return 0;
            }
        }
    }
}
