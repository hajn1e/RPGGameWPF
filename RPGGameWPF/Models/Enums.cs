using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public enum TileType
    {
        Floor,
        Wall,
        Exit,
    }

    public enum Direction
    {
        Up,
        Down,
        Left,
        Right,
    }

    public enum HeroClass
    {
        Warrior,
        Mage,
        Archer,
    }

    public enum EnemyType
    {
        Goblin,
        Skeleton,
    }

    public enum ItemType
    {
        Potion,
        Weapon,
        Armor,
    }

    public enum ItemRarity
    {
        Common,
        Rare,
        Epic,
    }
}
