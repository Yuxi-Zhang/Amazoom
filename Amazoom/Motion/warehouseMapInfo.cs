using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Amazoom.Motion
{
    public class warehouseMapInfo
    {
        public string mapName;
        public int mapX;
        public int mapY;
        public int[,] docksLocation;
        public int[,] shelvesLocation; //size of 2, first one represent the left top corner, the second one represents bottom right corner
        Mutex mut = new Mutex();
        public SemaphoreSlim semaphoreSlim = new SemaphoreSlim(1);
        bool flag;

        public warehouseMapInfo(string mapName, int mapX, int mapY, int[,] dockslocation, int[,] shelvesLocation)
        {
            this.mapX = mapX;
            this.mapY = mapY;
            this.mapName = mapName;
            this.docksLocation = dockslocation;
            this.shelvesLocation = shelvesLocation;
        }

        public bool mapRealTimeInfo(int locationX, int locationY, int botID)
        {

            if (locationY == mapY - 1)
            {
                Console.WriteLine($"\nRobot ID: {botID} is waiting");
                semaphoreSlim.Wait();
                Console.WriteLine($"\nRobot ID: {botID} enters shared rows\n");
                flag = false;
            }
            else
                flag = true;

            return flag;
        }
        //public void mapWait()
        //{
        //    semaphoreSlim.Wait();
        //}
        public bool mapRelease(int botID)
        {
            semaphoreSlim.Release();
            Console.WriteLine($"\nRobot ID: {botID} left shared rows");
            return flag = true;
        }

        public bool criticalRegionCheck(int locationX, int locationY)
        {
            bool flag;
            if (locationY == 0 || locationY == mapY - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
