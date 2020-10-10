using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    abstract class Item : Tile
    {
        protected Item(int y, int x) : base(y, x)
        {
        }

        public abstract string ToString();       
    }
}
