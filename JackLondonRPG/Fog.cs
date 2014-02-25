using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Fog:ActiveSkill
    {
        private const int maxUses = 2;
        public Fog():base()
        {
            this.Name = "Cast Fog";
            this.NumberOfUses = 2;
        }

        public override void Apply(object obj)
        {
            int targetIndex=ChooseTarget(obj as Ship);
            (obj as Ship).Cannons[targetIndex].Precision.RankChange(-1);
            this.NumberOfUses--;
        }
    }
}
