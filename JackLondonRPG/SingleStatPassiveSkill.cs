using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class SingleStatPassiveSkill:PassiveSkill
    {
        public override void Apply(Stat<int> stat, int manipulator)
        {
                stat.RankUp(manipulator);

        }
    }
}
