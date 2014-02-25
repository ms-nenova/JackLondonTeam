﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class PassiveSkill : Skill
    {

        public PassiveSkill():base()
        {
        }

        public override void Apply(object obj)
        {
            var cannons = (obj as Ship).Cannons;
            foreach(var cannon in cannons)
            {
                cannon.Damage.RankChange(1);
            }
        }
    }
}
