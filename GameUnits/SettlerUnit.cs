using System;
using System.Collections.Generic;
using System.Text;

namespace GameUnits
{
    class SettlerUnit : Unit
    {
        public override float Value => 5;

        public SettlerUnit(int mov, int health) : base(mov, health) { };
    }
}
}
