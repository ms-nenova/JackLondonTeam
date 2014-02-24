using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Repairman:NPC
    {
        private int pricePerPointRepair;

        public Repairman(string name, string job, int price):base(name,job)
        {
            this.PricePerPointRepair = price;
        }

        public int PricePerPointRepair
        {
            get
            {
                return this.pricePerPointRepair;
            }
            set
            {
                this.pricePerPointRepair = value;
            }
        }

        public void RepairSpecificWall(Wall wall) 
		{
			throw new System.NotImplementedException();
		}

        public void RepairAllWalls(List<Wall> walls)
		{
			throw new System.NotImplementedException();
		}
    }
}
