using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Captain
	{
        private string name;
        private Skill ability;

        public Captain (string name, Skill ability)
        {
            this.name = name;
            this.ability = ability;
        }

        public string Name
        {
            get
            {
               return this.name;
            }
            private set
            {
                this.name = value;
            }
        }

        public Skill Ability
        {
            get
            {
                return this.ability;
            }
            private set
            {
                this.ability = value;
            }
        }

        public void UseAbility(Skill skill)
        {
            // skill.Apply();
			throw new System.NotImplementedException();
        }
	}
}
