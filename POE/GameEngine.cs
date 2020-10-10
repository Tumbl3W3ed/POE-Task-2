using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    class GameEngine
    {
        private Map map;

        public Map Map
        {
            get => map;
        }

        public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount, int amountOfGoldPickUps)
        {
            map = new Map(minWidth, maxWidth, minHeight, maxHeight, enemyAmount, amountOfGoldPickUps);
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            if (direction == Character.MovementEnum.Left)
            {
                if (map.Hero.X - 1 != 0 && map.Hero.Vision[2] == null)
                {
                    map.ThisMap[map.Hero.Y, map.Hero.X] = null;
                    map.Hero.Move(Character.MovementEnum.Left);
                    map.ThisMap[map.Hero.Y, map.Hero.X] = map.Hero;
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Right)
            {
                if (map.Hero.X + 2 != map.MapWidth && map.Hero.Vision[3] == null)
                {
                    map.ThisMap[map.Hero.Y, map.Hero.X] = null;
                    map.Hero.Move(Character.MovementEnum.Right);
                    map.ThisMap[map.Hero.Y, map.Hero.X] = map.Hero;
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Up)
            {
                if (map.Hero.Y - 1 != 0 && map.Hero.Vision[0] == null)
                {
                    map.ThisMap[map.Hero.Y, map.Hero.X] = null;
                    map.Hero.Move(Character.MovementEnum.Up);
                    map.ThisMap[map.Hero.Y, map.Hero.X] = map.Hero;
                    return true;
                }
            }
            else
            {
                if (map.Hero.Y + 2 != map.MapHeight && map.Hero.Vision[1] == null)
                {
                    map.ThisMap[map.Hero.Y, map.Hero.X] = null;
                    map.Hero.Move(Character.MovementEnum.Down);
                    map.ThisMap[map.Hero.Y, map.Hero.X] = map.Hero;
                    return true;
                }
            }
            return false;
        }


    }
}
