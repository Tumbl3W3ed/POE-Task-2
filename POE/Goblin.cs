using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Goblin : Enemy
    {
        public Goblin(int y, int x) : base(y, x, 10, 1)
        {
            
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            int direction = random.Next(1, 5);
            while(HeroVision[direction].ThisTileType != TileType.Empty)
            {
                continue;
            }
            return (MovementEnum)direction;
        }
    }
}
