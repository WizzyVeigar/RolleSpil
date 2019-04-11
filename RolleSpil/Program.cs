using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Program
    {
        static void Main(string[] args)
        {
            Character mainChar = new Player(100, 5, 5, "Warrior");
            Wolf enemyWolf = new Wolf(60, 0, 5, "Wolf");
            ((Player)mainChar).weaponInventory.Add(new Weapon(5, 12, 10, "Copper Shortsword"));
            ((Player)mainChar).weaponInventory.Add(new Weapon(3, 6, 5, "Copper Dagger"));
            ((Player)mainChar).weaponInventory.Add(new Weapon(15, 31, 35, "Zweihander"));
            // ((Player)mainChar).Jump();
            Console.WriteLine(
                "Press 1. for monster hunt \n" +
                "Press 2. for shopping \n" +
                "Press 3. for inventory");
            string uInput = Console.ReadLine();

            switch (uInput)
            {
                case "1":
                    BattleSelect("1");
                    break;
            }

            void BattleSelect(string selectnumber)
            {
                switch (selectnumber)
                {
                    case "1":
                        Fight(mainChar, enemyWolf);
                        break;
                        //case "2":
                        //    Fight(mainChar, enemyDragon);
                        //    break;
                }
            }

            Character Fight(Character fighter1, Character fighter2)
            {
                Character winnerWinnerChickenDinner = null;
                while (winnerWinnerChickenDinner == null) 
                {
                    Console.WriteLine("You are against a " + fighter2.CharName + "! \n");
                    while (fighter1.Health > 0 && fighter2.Health > 0)
                    {
                        Console.WriteLine(
                        "What would you like to do?\n" +
                        "1. Attack!\n" +
                        "2. Use Potion\n" +
                        "3. Change Weapon");
                        string fightchoice = Console.ReadLine();
                        switch (fightchoice)
                        {
                            case "1":
                                int fighter1Dmg = fighter1.Attack(fighter2);
                                Console.WriteLine(
                                    "You attack the " + fighter2.CharName + " for " + fighter1Dmg + "!\n" +
                                    "The " + fighter2.CharName + " now has " + fighter2.Health + "HP left!");
                                Console.ReadKey();
                                if (fighter2.Health <= 0)
                                {
                                    winnerWinnerChickenDinner = fighter1;
                                }
                                int fighter2Dmg = fighter2.Attack(fighter1);
                                Console.WriteLine(
                                    "\nThe " + fighter2.CharName + " Swats back, dealing " + fighter2Dmg + " Damage!\n" +
                                    "You have " + fighter1.Health + "HP left!");
                                if (fighter1.Health <= 0)
                                {
                                    winnerWinnerChickenDinner = fighter2;
                                }
                                break;

                            //case "2":
                            //    if (Items.potioncount = 0)
                            //    {
                            //        Console.WriteLine("You don't have any potions!");
                            //    }
                            //    else
                            //    {
                            //        Items.PotionDrink(mainChar);
                            //    }
                            //    break;

                            case "3":
                                ((Player)mainChar).ShowAllWeapons();
                                List<Weapon> weaponList = ((Player)mainChar).ShowAllWeapons();
                                Console.Clear();
                                Console.WriteLine("What weapon would you like to switch to?");
                                for (int i = 0; i < weaponList.Count; i++)
                                {
                                    Console.WriteLine(i + ". " + weaponList[i].WeaponName + " " + weaponList[i].MinDamage + " " + weaponList[i].MaxDamage);
                                }
                                string chosenWeapon = Console.ReadLine();
                                ((Player)mainChar).ChangingWeapon(chosenWeapon);
                                break;
                        }
                    }
                }
                if(winnerWinnerChickenDinner == fighter1)
                {
                    Console.Clear();
                    Console.WriteLine("You defeated The" + fighter2.CharName + "! ");
                    ((Wolf)fighter2).WolfLoot(fighter1);
                }
                return winnerWinnerChickenDinner;
            }

        }
    }
}
