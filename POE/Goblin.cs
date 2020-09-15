using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Goblin : Enemy
    {
        public Goblin(int y, int x) : base(y, x, 10, 1, 'G')
        {

        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            int direction = random.Next(0, 4);
            while (vision[direction] != null)
            {
                direction = random.Next(0, 4);                
            }
            return (MovementEnum)direction+1;
        }
    }
}
