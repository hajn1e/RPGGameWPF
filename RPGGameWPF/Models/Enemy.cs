using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class Enemy : Character
    {
        public EnemyType Type { get; }
        public Enemy(EnemyType type , Position pos): base(pos)
        {
            Type = type;
            
            if (type == EnemyType.Goblin)
            {
                Name = "Goblin";
                MaxHp = 20;
                Hp = 20;
                BaseAttack = 5;
                BaseDefense = 1;
            }
            else if (type == EnemyType.Skeleton)
            {
                Name = "Skeleton";
                MaxHp = 25;
                Hp = 25;
                BaseAttack = 6;
                BaseDefense = 2;
            }

        }

        public Position DecideNextStep(Map map, Position heroPos)
        {
            int dx = Math.Sign(heroPos.X - Pos.X);
            int dy = Math.Sign(heroPos.Y - Pos.Y);

            var tryX= new Position(Pos.X + dx, Pos.Y);
            var tryY= new Position(Pos.X, Pos.Y + dy);

            if (dx != 0 && map.IsWalkable(tryX))return tryX;
            if (dy != 0 && map.IsWalkable(tryY))return tryY;
            return Pos; // Stay in place if can't move
        }

    }

}
