using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Merchant
    {
        public int PricePerRankUpCannon { get; set; }
        public int PricePerRankUpWall { get; set; }

        public void Upgrade(object obj);
    }
}
