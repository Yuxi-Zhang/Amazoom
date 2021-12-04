using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Amazoom.Motion
{
    class warehouseMapInfo
    {
        public string mapName;
        public int mapX;
        public int mapY;
        public int[,] docksLocation;
        public int[,] shelvesLocation; //size of 2, first one represent the left top corner, the second one represents bottom right corner
        Mutex mut = new Mutex();

        public warehouseMapInfo(string mapName, int mapX, int mapY, int[,] dockslocation, int[,] shelvesLocation)
        {
            this.mapX = mapX;
            this.mapY = mapY;
            this.mapName = mapName;
            this.docksLocation = dockslocation;
            this.shelvesLocation = shelvesLocation;
        }

        public bool mapRealTimeInfo(int locationX, int locationY)
        {
            bool flag;
            mut.WaitOne();
            if (locationX == mapX)
            {
                return flag = true;
            }
            else
            {
                return flag = false;
            }
            mut.Close();
        }
    }
}
