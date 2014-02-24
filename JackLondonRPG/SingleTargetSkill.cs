using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class SingleTargetSkill : ActiveSkill
    {
        public SingleTargetSkill(string name, int rankManipulator, int numberOfUses) : base(name, rankManipulator, numberOfUses) 
        {
        }

        public override void Apply(List<Stat<int>> stats, int manipulator)
        {
            stats.FirstOrDefault().RankChange(manipulator);
            NumberOfUses = NumberOfUses - 1;
        }
    }
}
