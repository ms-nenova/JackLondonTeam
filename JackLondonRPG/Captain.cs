using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace JackLondonRPG
{
	public class Captain
	{
        public string Name
        {
            get;
            set;
        }

        public Skill Ability
        {
            get;
            set;
        }

        public void UseAbility(Skill skill)
        {
            skill.Apply();
        }
	}
}
