﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Hero : Character
    {
        public Hero(int y, int x, int maxhp) : base(y, x, maxhp, 2)
        {
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + Hp + "/" + MaxHP + "\nDamage: 2\n" + "[" + X + "," + Y + "]";
        }
    }
}
