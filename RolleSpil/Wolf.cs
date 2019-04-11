using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Wolf : Enemy
    {

        public Wolf(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {
            EnemyDropPool = new List<Item>() { };
        }

        public override int Attack(Character target)
        {
            int dmgResult = target.Defend(20);
            return dmgResult;
        }

        public override List<Item> GiveLoot()
        {
            int rng = new Random().Next(0, 101);
            List<Item> drops = new List<Item>();
            if(rng < 1)
            {
                drops.Add( EnemyDropPool[0]);
            }
            else if (rng < 20)
            {
                drops.Add(EnemyDropPool[1]);
            }
            return drops;
        }

    }
}
