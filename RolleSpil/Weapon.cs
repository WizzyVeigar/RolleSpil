using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Weapon : Item
    {
        int minDamage;
        int maxDamage;
        int evasionAdjust;

        public int MinDamage
        {
            get { return minDamage; }
            set { minDamage = value; }
        }
        public int MaxDamage
        {
            get { return maxDamage; }
            set { maxDamage = value; }
        }

        public int EvasionAdjust
        {
            get { return evasionAdjust; }
            set { evasionAdjust = value; }
        }
        public Weapon(int minDamage, int maxDamage, int evasionAdjust, string weaponName)
        {
            MinDamage = minDamage;
            MaxDamage = maxDamage;
            EvasionAdjust = evasionAdjust;
            ItemName = weaponName;
        }
    }
}
