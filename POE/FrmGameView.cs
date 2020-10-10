using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POE
{
    public partial class FrmGameView : Form
    {
        GameEngine gameEngine;
        public FrmGameView()
        {
            InitializeComponent();
            gameEngine = new GameEngine(6, 8, 6, 8, 5, 4);
            updateMap();
        }

        public void updateMap()
        {
            string mapResult = "";
            const int padWidth = 5;
            for (int y = 0; y < gameEngine.Map.ThisMap.GetLength(0); y++)
            {
                for (int x = 0; x < gameEngine.Map.ThisMap.GetLength(1); x++)
                {
                    if (y == 0 || x == 0 || y == gameEngine.Map.ThisMap.GetLength(0) - 1 || x == gameEngine.Map.ThisMap.GetLength(1) - 1)
                    {
                        mapResult += $"{"X",padWidth}";
                    }
                    else if (gameEngine.Map.ThisMap[y, x] == null)
                    {
                        mapResult += $"{".",padWidth}";
                    }
                    else
                    {
                        if (gameEngine.Map.ThisMap[y, x].ThisTileType == Tile.TileType.Hero)
                        {
                            mapResult += $"{"H",padWidth}";
                        }
                        else if (gameEngine.Map.ThisMap[y, x].ThisTileType == Tile.TileType.Gold)
                        {
                            mapResult += $"{"g",padWidth}";
                        }
                        else if (gameEngine.Map.ThisMap[y, x].ThisTileType == Tile.TileType.Enemy)
                        {
                            mapResult += $"{"G",padWidth}";
                        }
                    }
                }
                mapResult += "\n\n";
            }
            LblMap.Text = mapResult;
            UpdateHeroStats();
            gameEngine.Map.UpdateVision();
            updateAttackTargets();
        }

        private void UpdateHeroStats()
        {
            LblPlayerStats.Text = gameEngine.Map.Hero.ToString();
        }

        private void FrmGameView_Load(object sender, EventArgs e)
        {

        }

        private void Attack(Character target)
        {
            gameEngine.Map.Hero.Attack(target);
            lblCombat.Text = ((Enemy)target).ToString();
            if (target.IsDead())
            {
                lblCombat.Text = "";
                gameEngine.Map.ThisMap[target.Y, target.X] = null;
                updateMap();
            }
        }


        private void updateAttackTargets()
        {
            btnAttackUp.Enabled = false;
            btnAttackDown.Enabled = false;
            btnAttackRight.Enabled = false;
            btnAttackLeft.Enabled = false;
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackUp.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackDown.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackLeft.Enabled = true;
                }
            if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1] != null)
                if (gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1].ThisTileType == Tile.TileType.Enemy)
                {
                    btnAttackRight.Enabled = true;
                }
        }

        private void BtnAttackUp_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Up - 1]);
        }

        private void BtnAttackDown_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Down - 1]);
        }

        private void BtnAttackLeft_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Left - 1]);
        }

        private void BtnAttackRight_Click(object sender, EventArgs e)
        {
            Attack((Character)gameEngine.Map.Hero.Vision[(int)Character.MovementEnum.Right - 1]);
        }

        private void btnMoveUp_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Up))
            {
                updateMap();
            }
        }

        private void btnMoveDown_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Down))
            {
                updateMap();
            }
        }

        private void btnMoveLeft_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Left))
            {
                updateMap();
            }
        }

        private void btnMoveRight_Click(object sender, EventArgs e)
        {
            if (gameEngine.MovePlayer(Character.MovementEnum.Right))
            {
                updateMap();
            }
        }
    }
}
