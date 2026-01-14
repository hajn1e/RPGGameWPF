using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class Tile
    {
        public TileType Type { get; set; }

        public Tile(TileType type)
        {
            Type = type;
        }
    }
}
