using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Amazoom.Motion
{
    public class robot
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
        public int RobotID;
        bool flag = true;



        public robot(int maxCapacity, double speed, warehouseMapInfo warehouse, int RobotID, int columnMin, int columnMax)
        {
            this.maxCapacity = maxCapacity;
            this.speed = speed;
            this.robotNumber = maxCapacity;
            this.warehouse = warehouse;
            this.itemsInRobot = 0;
            this.columnMax = columnMax;
            this.columnMin = columnMin;
            this.RobotID = RobotID;
        }

        public void findRoute(List<int[,]> items)
        {
            List<int> route = new List<int>();
            robotX = 0;
            robotY = 0;
            int listsize = items.Count;

            Console.WriteLine("Robot ID: " + RobotID.ToString() + " is working");
            for (i = 0; i < listsize; i++)
            {
                int[,] currentItem = items[0];

                //robot find items before full(with optimized path finder)
                while (true)
                {
                    if (robotX < currentItem[0, 0])
                    {
                        if (robotY == 0 || robotY == warehouse.mapY)
                            robotX += 1;

                        else if (robotY < 1.0 / 2.0 * warehouse.mapY && currentItem[0, 1] < 1.0 / 2.0 * warehouse.mapY)
                            robotY--;
                        else
                            robotY++;

                    }
                    else if (robotX > currentItem[0, 0]) //&& (robotX == 0 || robotY == warehouse.mapX)
                    {
                        if (robotY == 0 || robotY == warehouse.mapY)
                            robotX -= 1;

                        else if (robotY < 1.0 / 2.0 * warehouse.mapY && currentItem[0, 1] < 1.0 / 2.0 * warehouse.mapY)
                            robotY--;
                        else
                            robotY++;

                    }
                    else if (robotY < currentItem[0, 1])
                    {
                        robotY += 1;

                    }
                    else if (robotY > currentItem[0, 1])
                    {
                        robotY -= 1;

                    }
                    Console.WriteLine("Robot ID: " + RobotID.ToString() + $" X: {robotX}, Y: {robotY}");
                    if (robotX == currentItem[0, 0] && robotY == currentItem[0, 1])
                    {
                        items.RemoveAt(0);
                        itemsInRobot++;
                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" Pick up item {i} (location: {robotX}, {robotY})");

                        break;
                    }

                    Thread.Sleep(500);
                    //when reach its maxcapacity
                    while (itemsInRobot == maxCapacity)
                    {
                        //flag = warehouse.mapRealTimeInfo(robotX, robotY);


                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" heading to dock ");
                        int[,] xy = advacnePathFinder(robotX, robotY, warehouse.docksLocation);
                        robotX = xy[0, 0];
                        robotY = xy[0, 1];
                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" arrive dock (location: {robotX}, {robotY})");

                        if (robotX == warehouse.docksLocation[0, 0] && robotY == warehouse.docksLocation[0, 1])
                        {
                            itemsInRobot = 0;

                            xy = advacnePathFinder(robotX, robotY, currentItem);
                            robotX = xy[0, 0];
                            robotY = xy[0, 1];
                            flag = warehouse.mapRelease();
                        }

                    }


                }
            }
        }

        public int[,] advacnePathFinder(int robotX, int robotY, int[,] targetLocation)
        {
            int[,] xy = new int[,] { { 0, 0 } };

            while (true)
            {
                if (robotY == warehouse.mapY && flag == true)
                    flag = warehouse.mapRealTimeInfo(robotX, robotY, RobotID);

                if (robotX < targetLocation[0, 0])
                {
                    if (robotY == 0 || robotY == warehouse.mapY)
                        robotX += 1;

                    else if (robotY < 1.0 / 2.0 * warehouse.mapY && targetLocation[0, 0] < 1.0 / 2.0 * warehouse.mapY)
                        robotY--;
                    else
                        robotY++;

                }
                else if (robotX > targetLocation[0, 0])
                {
                    if (robotY == 0 || robotY == warehouse.mapY)
                        robotX -= 1;
                    //else if (robotY == 0 || robotY == warehouse.mapY && robotX > targetLocation[0, 0])
                    //    robotX -= 1;
                    else if (robotY < 1.0 / 2.0 * warehouse.mapY && targetLocation[0, 0] < 1.0 / 2.0 * warehouse.mapY)
                        robotY--;
                    else
                        robotY++;

                }
                else if (robotY < targetLocation[0, 1])
                {
                    robotY += 1;

                }
                else if (robotY > targetLocation[0, 1])
                {
                    robotY -= 1;

                }
                Console.WriteLine("Robot ID: " + RobotID.ToString() + $" X: {robotX}, Y: {robotY}");
                if (robotX == targetLocation[0, 0] && robotY == targetLocation[0, 1])
                    break;

            }
            xy[0, 0] = robotX;
            xy[0, 1] = robotY;
            return xy;
        }


    }
}
