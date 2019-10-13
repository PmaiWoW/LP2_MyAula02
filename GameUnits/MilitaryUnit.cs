using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    class MilitaryUnit : Unit
    {
        public int AttackPower { get; }
        public int XP { get; set; }
        public override int Health => base.Health + XP;
        public override float Value => AttackPower + XP;

        public MilitaryUnit(int mov, int health, int attackPower, int xp) 
            : base(mov, health)
        {
            AttackPower = attackPower;
            XP = xp;
        }
        public override string ToString() => $"{base.ToString()}" +
            $"AttackPower: {AttackPower}\nXP: {XP}";
    }
}
