using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class ActiveSkill:Skill
    {
        private int numberOfUses;

        public ActiveSkill(string name, int rankManipulator, int numberOfUses):base(name,rankManipulator)
        {
            this.NumberOfUses = numberOfUses;
        }

        public int NumberOfUses
        {
            get
            {
                return this.numberOfUses;
            }
            protected set
            {
                this.numberOfUses= value;
            }
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
