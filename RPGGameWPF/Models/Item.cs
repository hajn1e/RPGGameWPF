using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
   public abstract class Item
    {
        public string Name { get; }
        public ItemType Type { get; }
        public ItemRarity Rarity { get; }

        protected Item(string name, ItemType type, ItemRarity rarity)
        {
            Name = name;
            Type = type;
            Rarity = rarity;
        }

        public override string ToString() {
            string r = Rarity switch
            {
                ItemRarity.Common => "C",
                ItemRarity.Rare => "R",
                _ => "E"
            };
            return $"{Name} [{r}]";
        }

    }

    public class  WeaponItem:Item
    {
        public int DamageBonus { get; }
        public WeaponItem(string name, ItemRarity rarity, int damageBonus)
            : base(name, ItemType.Weapon, rarity)
        {
            DamageBonus = damageBonus;
        }
    }

    public class ArmorItem:Item
    {
        public int DefenseBonus { get; }
        public ArmorItem(string name, ItemRarity rarity, int defenseBonus)
            : base(name, ItemType.Armor, rarity)
        {
            DefenseBonus = defenseBonus;
        }
    }

    public class PotionItem:Item
    {
        public int HealAmount { get; }
        public PotionItem(string name, ItemRarity rarity, int healAmount)
            : base(name, ItemType.Potion, rarity)
        {
            HealAmount = healAmount;
        }
    }
}
