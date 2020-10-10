using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Mage : Enemy
    {
        public Mage(int y, int x, int maxHp, int Damage, char symbol) : base(y, x, maxHp, Damage, symbol)
        {
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            return MovementEnum.NoMovement;
        }

        public override bool CheckRange(Character target)
        {
            
            if(target.X == this.X || target.X == this.X-1 || target.X == this.X+1)
            {
                if(target.Y == this.Y || target.Y == this.Y - 1 || target.Y == this.Y + 1)
                    return true;
            }
            return false;
        }
    }
}
