using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class MonsterLoot
    {
        Weapon weapondrop;
        int golddrop;
        HealingPotion potiondrop;

        public Weapon WeaponDrop
        {
            get { return weapondrop; }
            set { weapondrop = value; }
        }
        public int GoldDrop
        {
            get { return golddrop; }
            set { golddrop = value; }
        }
        public HealingPotion PotionDrop
        {
            get { return potiondrop; }
            set { potiondrop = value; }
        }

        public MonsterLoot(Weapon weaponDrop, int goldDrop)
        {
            WeaponDrop = weaponDrop;
            GoldDrop = goldDrop;
        }
    }
}
