using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Enemy : Character
    {
        protected Random random = new Random();
        public Enemy(int y, int x, int maxHp, int Damage) : base(y, x, maxHp, Damage)
        {
        }

        public override MovementEnum ReturnMove(MovementEnum move)
        {
            throw new NotImplementedException();
        }

        public override string ToString()
        {
            return nameof(Enemy) + "at ["+this.X+","+this.Y+"] ["+this.Damage+"]";
        }
    }
}
