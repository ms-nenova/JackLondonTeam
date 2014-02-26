using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    public class Fog:ActiveSkill
    {
        private const int maxUses = 2;
        private const int rankDecrease = -1;
        public Fog(int numberOfUses,string name="Fog", string description = "Decreases the precision of a cannon.")
            :base(name,description,numberOfUses)
        {
            this.NumberOfUses = maxUses;
        }

        public override void Apply(object obj)
        {
            if (this.NumberOfUses > 0)
            {
                try
                {
                    object ob = ValidateItem(obj);
                    (ob as Cannon).Precision.RankChange(rankDecrease);
                    this.NumberOfUses--;
                }
                catch (InvalidTargetException)
                {
                    Console.WriteLine("The object you have selected is not a cannon. Select a cannon!"); ;
                }
            }
            else
            {
                Console.WriteLine("You have already used up this skill."); ;
            }
        }

        public object ValidateItem(object obj)
        {
            if (obj is Cannon)
            {
                return obj;
            }
            else
            {
                throw new InvalidTargetException("The target is not a cannon");
            }
        }
    }
}
