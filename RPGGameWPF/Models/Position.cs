using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public readonly struct Position
    {
        public int X { get; }
        public int Y { get; }

        public Position(int x, int y)
        {
            X = x;
            Y = y;
        }
        public Position Add(int dx, int dy)
        => new Position(X + dx, Y + dy);

        public override string ToString()
        { 
            return $"({X}, {Y})";
        }

    }
}
