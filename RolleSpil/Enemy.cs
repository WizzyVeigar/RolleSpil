using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    abstract class Enemy : Character
    {

        private List<Item> enemyDropPool;

        public List<Item> EnemyDropPool
        {
            get { return enemyDropPool; }
            set { enemyDropPool = value; }
        }

        public Enemy(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {
        }

        public abstract List<Item> GiveLoot();
    }
}
