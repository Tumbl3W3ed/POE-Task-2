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
            for (int x = 0; x < gameEngine.Map.ThisMap.GetLength(0); x++)
            {
                for (int y = 0; y < gameEngine.Map.ThisMap.GetLength(1); y++)
                {
                    if (x == 0 || y == 0 || x == gameEngine.Map.ThisMap.GetLength(0) - 1 || y == gameEngine.Map.ThisMap.GetLength(1) - 1)
                    {
                        mapResult += $"{"X",padWidth}";
                    }
                    else if (gameEngine.Map.ThisMap[x, y] == null)
                    {
                        mapResult += $"{".",padWidth}";
                    }
                    else
                    {
                        if (gameEngine.Map.ThisMap[x, y].ThisTileType == Tile.TileType.Hero)
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
    }
}
