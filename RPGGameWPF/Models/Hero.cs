using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class Hero : Character
    {
        public HeroClass Class { get; }
        public Inventory Inventory { get; }

        public Hero(HeroClass cls, Position startPo) : base(startPo)
        {
            Class = cls;
            Inventory = new Inventory();
            Name=cls switch
            {
                HeroClass.Warrior => "Harcos",
                HeroClass.Mage => "Mágus",   
                _ => "Íjász"
            };

            if (cls == HeroClass.Warrior)
            {
                MaxHp = 40;
                Hp = 40;
                BaseAttack = 7;
                BaseDefense = 4;
            }
            else if (cls == HeroClass.Mage)
            {
                MaxHp = 28;
                Hp = 28;
                BaseAttack = 10;
                BaseDefense = 2;
            }
            else if (cls == HeroClass.Archer)
            {
                MaxHp = 32;
                Hp = 32;
                BaseAttack = 8;
                BaseDefense = 3;
            }

            Inventory.AddItem(new PotionItem("Kis Potion", ItemRarity.Common, 12));
        }

        public int AttackTotal => BaseAttack + Inventory.Equipment.WeaponDamageBonus;
        public int DefenseTotal => BaseDefense + Inventory.Equipment.ArmorDefenseBonus;
    }
}
