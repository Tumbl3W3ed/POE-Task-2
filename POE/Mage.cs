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
            throw new NotImplementedException();
        }
    }
}
