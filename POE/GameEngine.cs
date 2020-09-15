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

        public GameEngine(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount)
        {
            map = new Map(minWidth, maxWidth, minHeight, maxHeight, enemyAmount);
        }

        public bool MovePlayer(Character.MovementEnum direction)
        {
            if (direction == Character.MovementEnum.Up)
            {
                if (map.Hero.Vision[0] == null)
                {
                    map.Hero.Move(Character.MovementEnum.Up);
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Down)
            {
                if (map.Hero.Vision[1] == null)
                {
                    map.Hero.Move(Character.MovementEnum.Down);
                    return true;
                }
            }
            else if (direction == Character.MovementEnum.Left)
            {
                if (map.Hero.Vision[2] == null)
                {
                    map.Hero.Move(Character.MovementEnum.Left);
                    return true;
                }
            }
            else
            {
                if (map.Hero.Vision[3] == null)
                {
                    map.Hero.Move(Character.MovementEnum.Right);
                    return true;
                }
            }
            return false;
        }

        private void textBox1_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (MovePlayer(Character.MovementEnum.Up))
                {
                    map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (MovePlayer(Character.MovementEnum.Down))
                {
                   
                    map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (MovePlayer(Character.MovementEnum.Left))
                {
                    map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (MovePlayer(Character.MovementEnum.Right))
                {
                    map.UpdateVision();
                }
            }
        }
    }
}
