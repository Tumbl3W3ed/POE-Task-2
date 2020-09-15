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
            gameEngine = new GameEngine(6,8,6,8,5);

            updateMap();
        }

        public void updateMap()
        {
            string mapResult="";
            for (int x = 0; x < gameEngine.Map.ThisMap.GetLength(0); x++)
            {
                for (int y = 0; y < gameEngine.Map.ThisMap.GetLength(1); y++)
                {
                    if(x==0||y == 0 || x== gameEngine.Map.ThisMap.GetLength(0)-1 ||y== gameEngine.Map.ThisMap.GetLength(1)-1)
                    {
                        mapResult += "X";
                    }
                    else if(gameEngine.Map.ThisMap[x,y] == null)
                    {
                        mapResult += ".";
                    }
                    else
                    {
                        if (gameEngine.Map.ThisMap[x, y].ThisTileType == Tile.TileType.Hero)
                        {
                            mapResult += "H";
                        }
                        else
                        {
                            mapResult += "G";
                        }                        
                    }                    
                }
                mapResult += "\n";
            }
            LblMap.Text = mapResult;
        }
    }
}
