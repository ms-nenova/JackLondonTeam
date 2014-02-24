using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Merchant:NPC
    {
        private int pricePerRankCannon;
        private int pricePerRankWall;

        public Merchant(string name, string job, int priceCannon, int priceWall):base(name, job)
        {
            this.PricePerRankUpCannon = priceCannon;
            this.PricePerRankWall = priceWall;
        }


        public int PricePerRankUpCannon
        {
            get
            {
                return this.pricePerRankCannon;
            }
            set
            {
                this.pricePerRankCannon = value;
            }
        }


        public int PricePerRankWall
        {
            get
            {
                return this.pricePerRankWall;
            }
            set
            {
                this.pricePerRankWall = value;
            }
        }

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
