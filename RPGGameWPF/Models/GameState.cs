using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class GroundDop
    {
        public Position Pos { get; set; }
        public Item Item { get; set; }

        public GroundDop(Position pos, Item item)
        {
            Pos = pos;
            Item = item;
        }
    }

    public class Chest
    {
        public Position Pos { get; set; }
        public bool Opened { get; private set; }

        public Chest(Position pos)
        {
            Pos = pos;
            Opened = false;
        }
        public void Open()
        {
            Opened = true;
        }
    }
    public class GameState
    {
        public Map Map { get; }
        public Hero Player { get; }

        public List<Enemy> Enemies { get; }

        public List<GroundDop> GroundDops { get; }
        public List<Chest> Chests { get; }
        public Quest Active {get;}
        public int Gold { get; set; }
        public bool IsGameOver { get; set; }
        public bool isWin { get; set; }

        public GameState(Map map, Hero player)
        {
                        Map = map;
            Player = player;
            Enemies = new List<Enemy>();
            GroundDops = new List<GroundDop>();
            Chests = new List<Chest>();
            Active = new Quest("Ölj meg 3 Goblint", 3);
            Gold = 0;
            IsGameOver = false;
            isWin = false;
        }

    }
}
