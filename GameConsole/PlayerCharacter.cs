﻿using System;
namespace GameConsole
{
    public class PlayerCharacter
    {
        private readonly SpecialDefence _specialDefence;

        public PlayerCharacter(SpecialDefence specialDefence)
        {
            _specialDefence = specialDefence;
        }

        public string Name { get; set; } = "Sauron";
        public int Health { get; set; } = 100;

        public void Hit(int damage)
        {
            int totalDamageTaken = damage - _specialDefence.CalculateDamageReduction(damage);

            Health -= totalDamageTaken;

            Console.WriteLine($"{Name}'s health has been reduced by {totalDamageTaken} to {Health}");
        }
    }
}
