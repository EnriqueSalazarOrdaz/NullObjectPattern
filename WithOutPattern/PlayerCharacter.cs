using System;
using System.Collections.Generic;
using System.Text;

namespace WithOutPattern
{
    class PlayerCharacter
    {
        private ISpecialDefence _specialDefence;

        public PlayerCharacter(ISpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }
        public string Name { get; set; }
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            var totalDmg = damage - _specialDefence.ReduceDamage(damage);
            Health = Health - totalDmg;
            Console.WriteLine($"{Name}'s has {Health}hp");
        }
    }
}
