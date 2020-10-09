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
            MapWidth = random.Next(minWidth, maxWidth);
            MapHeight = random.Next(minHeight, maxHeight);
            map = new Tile[MapWidth, MapHeight];
            for (int x = 0; x < map.GetLength(0); x++)
            {
                for (int y = 0; y < map.GetLength(1); y++)
                {
                    map[x, y] = null;
                }
            }
            enemies = new Enemy[enemyAmount];
            for (int i = 0; i < enemies.Length; i++)
            {
                enemies[i] = (Enemy)Create(Tile.TileType.Enemy);
                enemies[i].ThisTileType = Tile.TileType.Enemy;
                map[enemies[i].X, enemies[i].Y] = enemies[i];
            }
            hero = (Hero)Create(Tile.TileType.Hero);
            map[hero.X, hero.Y] = hero;
        }

        private Tile Create(Tile.TileType type)
        {
            switch (type)
            {
                case Tile.TileType.Hero:
                    return new Hero(random.Next(1, MapHeight), random.Next(1, MapWidth), 40);
                case Tile.TileType.Enemy:
                    int x, y;
                    x = random.Next(1, MapWidth);
                    y = random.Next(1, MapHeight);
                    while (map[x, y] != null)
                    {
                        x = random.Next(1, MapWidth);
                        y = random.Next(1, MapHeight);
                    }
                    return new Goblin(x, y);
            }
            return null;
        }

        public void UpdateVision()
        {
            UpdateCharacterVision(hero);
            foreach (Character c in enemies)
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
