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

        public Skill()
        {
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



        public abstract void Apply(object obj);

    }
}
