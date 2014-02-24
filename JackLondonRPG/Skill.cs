using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    public abstract class Skill
    {
        private string name;
        private int rankManipulator;

        public Skill(string name, int rankManipulator)
        {
            this.Name = name;
            this.RankManipulator = rankManipulator;
        }

        public string Name
        { 
			get
            {
                return this.name;
            }
			set
            {
                this.name = value;
            }
		}

        public int RankManipulator
        {
            get
            {
                return this.rankManipulator;
            }
            set
            {
                this.rankManipulator = value;
            }
        }

        public abstract void Apply(List<Stat<int>> stats, int manipulator);

    }
}
