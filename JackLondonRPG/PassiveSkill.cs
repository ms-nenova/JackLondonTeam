using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class PassiveSkill : Skill
    {
        public override void Apply(List<Stat<int>> stats, int manipulator)
        {
            foreach (var stat in stats)
            {
                stat.RankUp(manipulator);                
            }
        }
    }
}
