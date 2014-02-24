using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JackLondonRPG
{
    class Repairman:NPC
    {
        public int PricePerPointRepair { get; set; }

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
