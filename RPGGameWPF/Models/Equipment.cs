using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGameWPF.Models
{
    public class Equipment
    {
        public WeaponItem? Weapon { get; private set; }
        public ArmorItem? Armor { get; private set; }

        public int WeaponDamageBonus => Weapon?.DamageBonus ?? 0;
        public int ArmorDefenseBonus => Armor?.DefenseBonus ?? 0;

        public void Equip(Item item)
        {
            if(item is WeaponItem w) Weapon = w;
            if(item is ArmorItem a) Armor = a;
            
        }
    }

    public class Inventory
    {
        private List<Item> items;
        public IReadOnlyList<Item> Items => items;

        public Equipment Equipment { get; }
        public Inventory()
        {
            items = new List<Item>();
            Equipment = new Equipment();
        }
        public void AddItem(Item item)
        {
            items.Add(item);
        }
        public void RemoveItem(Item item)
        {
            items.Remove(item);
        }
    }
}
