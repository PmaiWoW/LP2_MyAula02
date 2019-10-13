using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    abstract class Unit
    {
        private int movement;
        public virtual int Health { get; private set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }

        public void Move()
        {
            Console.WriteLine($"Unit moves {movement} tiles.");
        }

        public override string ToString() => $"{GetType()}:\nHealth: " +
            $"{Health}\nValue: {Value}\n";
    }
}
