using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Amazoom.Motion
{
    class robot
    {
        public int maxCapacity;
        public int columnMin;
        public int columnMax;
        public double speed;
        public int robotNumber;
        public int totalRobot;
        public warehouseMapInfo warehouse;
        public int i;
        public int robotX;
        public int robotY;
        public int itemsInRobot;
        public int robotManageColumn;
        


        public robot(int maxCapacity, double speed, warehouseMapInfo warehouse, int columnMin, int columnMax)
        {
            this.maxCapacity = maxCapacity;
            this.speed = speed;
            this.robotNumber = maxCapacity;
            this.warehouse = warehouse;
            this.itemsInRobot = 0;
            this.columnMax = columnMax;
            this.columnMin = columnMin;
        }

        public void findRoute(List<int[,]> items)
        {
            List<int> route = new List<int>();
            bool flag = false;
            robotX = 0;
            robotY = 0;
            int listsize = items.Count;

            for (i = 0; i < listsize; i++)
            {
                int[,] currentItem = items[0];
                flag = warehouse.mapRealTimeInfo(robotX, robotY);

                if (flag == false)
                {
                    if (robotX < currentItem[0, 0] && (robotX == 0 || robotY == warehouse.mapX))
                    {
                        robotX += 1;
                        Thread.Sleep(200);
                    }
                    else if (robotY < currentItem[0, 1])
                    {
                        robotY += 1;
                        Thread.Sleep(200);
                    }
                    else if (robotY > currentItem[0, 1])
                    {
                        robotY -= 1;
                        Thread.Sleep(200);
                    }
                    else if (robotX > currentItem[0, 0] && (robotX == 0 || robotY == warehouse.mapX))
                    {
                        robotX -= 1;
                        Thread.Sleep(200);
                    }
                    if (robotX == currentItem[0, 0] && robotY == currentItem[0, 1])
                    {
                        items.RemoveAt(0);
                        itemsInRobot++;
                    }

                    while (itemsInRobot == maxCapacity)
                    {
                        if (robotY < warehouse.docksLocation[0, 1])
                        {
                            robotY += 1;
                        }
                        else if (robotY < warehouse.docksLocation[0, 1])
                        {
                            robotY -= 1;
                        }
                        else if ((robotX < warehouse.docksLocation[0, 0]))
                        {
                            robotX += 1;
                        }
                        else if ((robotX > warehouse.docksLocation[0, 0]))
                        {
                            robotX -= 1;
                        }
                        if (robotX == warehouse.docksLocation[0, 0] && robotY == warehouse.docksLocation[0, 1])
                        {
                            itemsInRobot = 0;
                        }
                    }

                }
            }
        }

        //public int[,] routeFinder(int X, int Y, int[,] item)
        //{

        //}
    }
}
