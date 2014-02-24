using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    public abstract class Skill
    {
        public string Name
        { 
			get;
			set;
		}

        public int RankManipulator
        {
            get;
            set;
        }

        public abstract void Apply(List<Stat<int>> stats, int manipulator);

    }
}
