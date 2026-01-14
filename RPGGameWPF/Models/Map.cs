using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class Map
    {
        public int Width { get; }
        public int Height { get; }
        public Tile[,] Tiles { get; }
        public Position ExitPos { get; private set; }
        public Map(int width, int height)
        {
            Width = width;
            Height = height;
            Tiles = new Tile[width, height];

            for (int x = 0; x < width; x++)
            {
                for (int y = 0; y < height; y++)
                {
                    Tiles[x, y] = new Tile(TileType.Floor);
                }
            }
        }

        public bool InBounds(Position p)
        {
            return p.X >= 0 && p.X < Width && p.Y >= 0 && p.Y < Height;
        }
        public bool IsWalkable(Position p)
        {
            //pályán belül van
            if (!InBounds(p)) return false;

            //ha bent van és nem fal
            return Tiles[p.X, p.Y].Type != TileType.Wall;
        }

        public void GenerateRandom(int seed)
        {
            var rnd = new Random(seed);

            for (int x = 0; x < Width; x++)
            {
                for (int y = 0; y < Height; y++)
                {
                    Tiles[x, y].Type = TileType.Floor;
                }
            }

            for (int x = 0; x < Width; x++)
            {
                Tiles[x, 0].Type = TileType.Wall;
                Tiles[x, Height - 1].Type = TileType.Wall;
            }

            for (int y=0; y < Height; y++)
            {
                Tiles[0,y].Type= TileType.Wall;
                Tiles[Width-1,y].Type = TileType.Wall;
            }

            //belső falak meghatározása
            int wallCount = (Width * Height) / 7;

            for (int i = 0; i < wallCount; i++) 
            {
                int x = rnd.Next(1, Width - 1);
                int y = rnd.Next(1, Height - 1);

                if((x==1) && (y==1) || (x == Width - 2 && y == Height - 2))
                            continue;
                Tiles[x, y].Type = TileType.Wall;
            }
            ExitPos = new Position(Width - 2, Height - 2);
            Tiles[ExitPos.X, ExitPos.Y].Type = TileType.Exit;

            Tiles[1,1].Type = TileType.Floor;

        }


    }
}
