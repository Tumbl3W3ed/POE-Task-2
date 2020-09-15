using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POE
{
    class Map
    {
        private Tile[,] map { get; set; }
        private Hero hero;
        private Enemy[] enemies;
        private int MapWidth;
        private int MapHeight;
        private Random random = new Random();

        public Tile[,] ThisMap
        {
            get => map;
            set => map = value;
        }

        public Hero Hero
        {
            get => hero;
            set => hero = value;
        }

        public Enemy[] Enemies
        {
            get => enemies;
            set => enemies = value;
        }
        public Map(int minWidth, int maxWidth, int minHeight, int maxHeight, int enemyAmount)
        {
            MapWidth = random.Next(minWidth, maxWidth + 1);
            MapHeight = random.Next(minHeight, maxHeight + 1);
            map = new Tile[MapWidth, MapHeight];
            enemies = new Enemy[enemyAmount];
            for(int i = 0; i < enemies.Length; i++) { 
               enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
            }
            hero = (Hero)Create(Tile.TileType.Hero);
        }

        private Tile Create(Tile.TileType type)
        {
            switch (type)
            {
                case Tile.TileType.Hero:
                    
                    return new Hero(random.Next(1, MapHeight), random.Next(1, MapWidth), 40);

                case Tile.TileType.Enemy:
                    return new Goblin(random.Next(1, MapHeight), random.Next(1, MapWidth));

            }
            return null;
        }

        public void UpdateVision()
        {
            UpdateCharacterVision(hero);
            foreach(Character c in enemies)
            {
                UpdateCharacterVision(c);
            }
        }

        public void UpdateCharacterVision(Character character)
        {
            character.Vision = new Tile[4]{map[character.X, character.Y-1], 
                map[character.X, character.Y - 1], map[character.X - 1, character.Y],
                map[character.X + 1, character.Y] };
        }
    }
}
