using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    abstract class Unit
    {
        private int movement;
        public int Health { get; private set; }
        public abstract float Value { get; }

        public Unit(int movement, int health)
        {
            this.movement = movement;
            Health = health;
        }
    }
}
