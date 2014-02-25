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

        public ActiveSkill():base()
        {
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

        public override void Apply(object obj)
        {
        }

        public int ChooseTarget(Ship ship)
        {
            int target = new int();
            Console.WriteLine("Choose a target for your ability [0-5]");
            target = int.Parse(Console.ReadLine());

            return target;
        }
    }
}
