using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Fireball:ActiveSkill
    {
        private const int maxUses = 2;
        public Fireball():base()
        {
            this.Name = "Fireball";
            this.NumberOfUses = maxUses;
        }

        public override void Apply(object obj)
        {
            int targetIndex=ChooseTarget(obj as Ship);
            (obj as Ship).Walls[targetIndex].GetDamaged(10);
            this.NumberOfUses--;
        }

    }
}
