using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Hero : Tile
    {
        protected int Hp;
        int MaxHP;
        int Damage;
        Tile[] HeroVision;
        public Hero(int y, int x) : base(y, x)
        {
        }

        public enum Movement
        {
            NoMovement, Up, Down, Left, Right
        }
    }
}
