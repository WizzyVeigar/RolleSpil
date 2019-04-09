using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Player : Character
    {
        public Weapon[] weaponinventory = new Weapon[2] { new Weapon(5, 12, 10, "Copper Shortsword"), new Weapon(3, 6, 5, "Copper Dagger") };


        public Player(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {

        }

        public override int Attack(Character target)
        {
            int dmgResult = target.Defend(Strength);
            return dmgResult;
        }
        public void Use(Items usableItem)
        {

        }

        public Weapon ChangingWeapon() { }
        public Weapon[] ShowAllWeapons()
        {
            return weaponinventory;
        }
    }
}
