using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public abstract class Character
    {
        public string Name { get; protected set; }
        public Position Pos { get;set; }
        public int MaxHp { get; protected set; }
        public int Hp { get; set;}
        public int BaseAttack { get; protected set; }
        public int BaseDefense { get; protected set; }

        public bool IsAlive => Hp > 0;  
        protected Character(Position startPos) 
        { 
            Pos = startPos;
        }
    }
}
