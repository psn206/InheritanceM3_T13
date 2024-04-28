using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class MultiBuilding : Building
    {
        int buildingNumFloors;
        public MultiBuilding(string buildingAddress, int buildingLength, int boildingWidth, int boildingHeight, int buildingNumFloors)
            : base(buildingAddress, buildingLength, boildingWidth, boildingHeight)
        {
            this.BuildingNumFloors = buildingNumFloors;

        }

        public int BuildingNumFloors { get; set; }

        public string Print()
        {
            return base.Print() + $"Этажность: {BuildingNumFloors}\n";
        }
    }
}
