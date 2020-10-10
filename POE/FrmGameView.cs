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
            gameEngine = new GameEngine(6, 8, 6, 8, 5);
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
                        else
                        {
                            mapResult += $"{"G",padWidth}";
                        }
                    }
                }
                mapResult += "\n\n";
            }
            LblMap.Text = mapResult;
            UpdateHeroStats();
        }

        private void UpdateHeroStats()
        {
            LblPlayerStats.Text = gameEngine.Map.Hero.ToString();
        }

        private void FrmGameView_Load(object sender, EventArgs e)
        {

        }

        private void FrmGameView_KeyDown(object sender, KeyEventArgs e)
        {
            Console.WriteLine("moved");

            if (e.KeyCode == Keys.Up || e.KeyCode == Keys.W)
            {
                if (gameEngine.MovePlayer(Character.MovementEnum.Up))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Down || e.KeyCode == Keys.S)
            {
                if (gameEngine.MovePlayer(Character.MovementEnum.Down))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Left || e.KeyCode == Keys.A)
            {
                if (gameEngine.MovePlayer(Character.MovementEnum.Left))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            if (e.KeyCode == Keys.Right || e.KeyCode == Keys.D)
            {
                if (gameEngine.MovePlayer(Character.MovementEnum.Right))
                {
                    gameEngine.Map.UpdateVision();
                }
            }
            updateMap();
        }
    }
}
