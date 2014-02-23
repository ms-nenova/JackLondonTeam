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

        public void RepairSpecificWall(Wall wall);

        public void RepairAllWalls(List<Wall> walls);
    }
}
