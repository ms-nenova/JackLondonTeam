using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class ActiveSkill:Skill
    {
        public int NumberOfUses
        {
            get;
            set;
        }

        public override void Apply(List<Stat<int>> stats, int manipulator)
        {
            foreach (var stat in stats)
            {
                stat.RankChange(manipulator);
                NumberOfUses = NumberOfUses - 1;
            }
        }
    }
}
