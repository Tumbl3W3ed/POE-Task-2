using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    class Hero : Character
    {
        public Hero(int y, int x, int maxhp) : base(y, x, maxhp, 2, 'H')
        {
            this.ThisTileType = TileType.Hero;
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {            
            return move;
        }

        public override string ToString()
        {
            return "Player Stats:\n" + "HP: " + hp + "/" + maxHP + "\nDamage: 2\n" + "[" + X + "," + Y + "]";
        }
    }
}
