using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class SingleTargetSkill:ActiveSkill
    {
        public override void Apply(Stat<int> stat,int manipulator)
        {
            stat.RankUp(manipulator);
            NumberOfUses = NumberOfUses - 1;
        }
    }
}
