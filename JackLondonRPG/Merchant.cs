using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Merchant:NPC
    {
        public int PricePerRankUpCannon { get; set; }
        public int PricePerRankUpWall { get; set; }

        public void Upgrade(Stat<int> stat)
		{
			throw new System.NotImplementedException();
		}

        public void Upgrade(List<Stat<int>> stat)
		{
			throw new System.NotImplementedException();
		}
    }
}
