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
    }
}
