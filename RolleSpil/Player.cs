using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Player : Character
    {
        public List<Weapon> weaponInventory = new List<Weapon>();
        public List<Item> inventory = new List<Item>() { new Weapon(1, 2, 3, "Lars' Sværd"), new HealingPotion(), new HealingPotion(), new Weapon(1, 2, 3, "Dennis' Hammer") };
        public Weapon currentWeapon = new Weapon(3, 6, 20, "Fists");
        int playerGold = 20;
        public Player(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {

        }

        public override int Attack(Character target)
        {
            int rngDmg = new Random().Next(currentWeapon.MinDamage, currentWeapon.MaxDamage + 1);
            int dmgResult = target.Defend(rngDmg);
            return dmgResult;
        }

        public Weapon ChangingWeapon(string chosenWeapon)
        {
            Weapon oldCurrent = currentWeapon;
            int x = Convert.ToInt32(chosenWeapon);
            currentWeapon = weaponInventory[x];
            weaponInventory.RemoveAt(x);
            weaponInventory.Insert(x, oldCurrent);
            return currentWeapon;
        }

        public List<Weapon> ShowAllWeapons()
        {
            List<Weapon> weaponsToReturn = new List<Weapon>();
            foreach (Item item in inventory)
            {
                if (item is Weapon)
                    weaponsToReturn.Add((Weapon)item);
            }
            return weaponInventory;
        }

        public void GetLoot(Item item)
        {
            inventory.Add(item);
        }

        public void GetLoot(List<Item> items)
        {
            inventory.AddRange(items);
        }
    }
}
