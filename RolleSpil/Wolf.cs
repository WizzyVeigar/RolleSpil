﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RolleSpil
{
    class Wolf : Character
    {
        public Wolf(int health, int defense, int strength, string charName) : base(health, defense, strength, charName)
        {

        }

        public override int Attack(Character target)
        {
            int dmgResult = target.Defend(20 + Strength);
            return dmgResult;
        }

    }
}