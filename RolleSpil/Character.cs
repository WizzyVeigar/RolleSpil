using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    abstract class Character
    {
        int health;
        public int Health
        {
            get { return health; }
            set { health = value; }
        }
        int defense;
        public int Defense
        {
            get { return defense; }
            private set { defense = value; }
        }
        int strength;
        public int Strength
        {
            get { return strength; }
            private set { strength = value; }
        }
        string charName;
        public string CharName
        {
            get { return charName; }
            private set { charName = value; }
        }
        int evasion;
        public int Evasion
        {
            get { return evasion; }
            set { evasion = value; }
        }
        public Character(int health, int defense, int strength, string charName)
        {
            Health = health;
            Defense = defense;
            Strength = strength;
            CharName = charName;
            Evasion = 5;
        }
  
        public int Defend(int bdmg)
        {
            Health -= Strength + bdmg;
            return Strength + bdmg; 
        }


        /// <summary>
        /// This is the Attack Method
        /// </summary>
        /// <param name="target">The Target to Attack</param>
        /// <returns>Returns the Damage given</returns>
        /// author: Kenneth
        public abstract int Attack(Character target);
        //public abstract MonsterLoot LootDrop(Character target);
    }
}
