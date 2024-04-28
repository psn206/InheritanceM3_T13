using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task
{
    internal class Building
    {
        string buildingAddress;
        int buildingLength;
        int boildingWidth;
        int boildingHeight;

        public Building(string buildingAddress, int buildingLength, int boildingWidth, int boildingHeight)
        {
            this.BuildingAddress = buildingAddress;
            this.BuildingLength = buildingLength;
            this.BoildingWidth = boildingWidth;
            this.BoildingHeight = boildingHeight;
        }

        public string BuildingAddress { get; set; }
        public int BuildingLength { get; set; }
        public int BoildingWidth { get; set; }
        public int BoildingHeight { get; set; }


        public string Print()
        {
            return $"Адресс: {BuildingAddress}\n" +
                   $"Длина: {BuildingLength}\n" +
                   $"Ширина: {BoildingWidth}\n" +
                   $"Высота: {BoildingHeight}\n";
        }

    }
}
