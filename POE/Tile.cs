using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    abstract class Tile
    {
        protected Tile(int y, int x)
        {
            Y = y;
            X = x;
        }

        public int Y { get; set; }
        public int X { get; set; }

        public TileType ThisTileType { get; set; }
        public enum TileType
        {
            Hero, Enemy, Gold, Weapon, Empty
        }
    }
}
