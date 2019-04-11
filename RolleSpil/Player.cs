using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Player : Character
    {
        //public Weapon[] weaponinventory = new Weapon[2] { new Weapon(5, 12, 10, "Copper Shortsword"), new Weapon(3, 6, 5, "Copper Dagger") };
        public List<Weapon> weaponInventory = new List<Weapon>();
        public Weapon currentWeapon = new Weapon(3,6,20, "Fists");
        int playerGold = 20;
        public Player(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {

        }

        public override int Attack(Character target)
        {
            int rngDmg = new Random().Next(currentWeapon.MinDamage, currentWeapon.MaxDamage+1);
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
            return weaponInventory;
        }

        public void GetLoot(Weapon weaponLoot, int goldLoot)
        {
            weaponInventory.Add(weaponLoot);
            playerGold += goldLoot;
        }
    }
}
