using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class SingleStatPassiveSkill:PassiveSkill
    {
        public SingleStatPassiveSkill(string name, int rankManipulator):base(name, rankManipulator)
        {
        }
        public override void Apply(List<Stat<int>> stats, int manipulator)
        {
			stats.FirstOrDefault().RankChange(manipulator);
        }
    }
}
