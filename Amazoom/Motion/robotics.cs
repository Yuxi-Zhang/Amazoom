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
        bool criticalCheckFlag;



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

        public void findRoute(List<int[,]> items, int action)   //action =1 pick up items. action = 2, restock
        {
            List<int> route = new List<int>();
            robotX = 0;
            robotY = 0;
            int listsize = items.Count;
            int[,] xy;
            int[,] currentItem;

            Console.WriteLine("Robot ID: " + RobotID.ToString() + " is working");
            if (action == 1)
            {
                for (i = 0; i < listsize; i++)
                {
                    if (items.Count <= 0)
                    {
                        break;
                    }
                    currentItem = items[0];
                    Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" items in List: {items.Count}");
                    //robot find items before full(with optimized path finder)
                    while (true)
                    {

                        xy = advacnePathFinder(robotX, robotY, currentItem);
                        robotX = xy[0, 0];
                        robotY = xy[0, 1];

                        if (robotX == currentItem[0, 0] && robotY == currentItem[0, 1])
                        {
                            if (items.Count > 0)
                            {
                                items.RemoveAt(0);
                                Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" items in List: {items.Count}");
                            }
                            itemsInRobot++;
                            Console.WriteLine("Robot ID: " + RobotID.ToString() + $" picks up item {i} (location: {robotX}, {robotY}) and items in robot: {itemsInRobot}");
                            if ((itemsInRobot == maxCapacity || i == listsize - 1) == false)
                                break;
                            else { };
                        }

                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" X: {robotX}, Y: {robotY}");
                        //when reach its maxcapacity
                        while (itemsInRobot == maxCapacity || i == listsize - 1)
                        {
                            Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" is heading to dock");
                            xy = advacnePathFinder(robotX, robotY, warehouse.docksLocation);
                            robotX = xy[0, 0];
                            robotY = xy[0, 1];

                            Console.WriteLine("Robot ID: " + RobotID.ToString() + $" arrives dock (location: {robotX}, {robotY})");

                            if (robotX == warehouse.docksLocation[0, 0] && robotY == warehouse.docksLocation[0, 1])
                            {

                                Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" items left in List: {items.Count}");
                                itemsInRobot = 0;
                                if (i == listsize - 1)
                                {
                                    Console.WriteLine("Robot ID: " + RobotID.ToString() + $" is heading home! ");
                                    xy = advacnePathFinder(robotX, robotY, new int[,] { { 0, 0 } });
                                    robotX = xy[0, 0];
                                    robotY = xy[0, 1];
                                    Console.WriteLine("Robot ID: " + RobotID.ToString() + $" arrives home (location: {robotX}, {robotY})");
                                    break;
                                }
                                else
                                {
                                    break;
                                }
                            }

                        }
                        break;

                    }

                }
            }
            else if (action == 2)
            {
                //robot find items before full(with optimized path finder)
                while (items.Count != 0)
                {

                    Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" is heading to dock for restocking");
                    xy = advacnePathFinder(robotX, robotY, warehouse.docksLocation);
                    robotX = xy[0, 0];
                    robotY = xy[0, 1];

                    if (maxCapacity > listsize)
                    {
                        itemsInRobot = listsize % maxCapacity;
                    }
                    else
                    {
                        itemsInRobot = maxCapacity;
                    }
                    Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" Items in List: {itemsInRobot}");

                    while (itemsInRobot != 0)
                    {
                        currentItem = items[0];
                        xy = advacnePathFinder(robotX, robotY, currentItem);
                        robotX = xy[0, 0];
                        robotY = xy[0, 1];

                        if (robotX == currentItem[0, 0] && robotY == currentItem[0, 1])
                        {

                            if (itemsInRobot != 0)
                            {
                                items.RemoveAt(0);
                                Console.WriteLine("\nRobot ID: " + RobotID.ToString() + $" Items in List: {items.Count}");
                                itemsInRobot--;
                                Console.WriteLine("Robot ID: " + RobotID.ToString() + $" drop item {i} (location: {robotX}, {robotY}) and items in robot: {itemsInRobot}");
                            }
                            else
                                break;

                        }
                    }
                    if (items.Count == 0)
                    {
                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" is heading home! ");
                        xy = advacnePathFinder(robotX, robotY, new int[,] { { 0, 0 } });
                        robotX = xy[0, 0];
                        robotY = xy[0, 1];
                        Console.WriteLine("Robot ID: " + RobotID.ToString() + $" arrives home (location: {robotX}, {robotY})");
                        break;
                    }

                }



            }
        }
        public int[,] advacnePathFinder(int robotX, int robotY, int[,] targetLocation)
        {
            int[,] xy = new int[,] { { 0, 0 } };

            while (true)
            {
                //Thread.Sleep(100);
                if (robotX < targetLocation[0, 0])
                {
                    if (robotY == 0 || robotY == warehouse.mapY - 2)
                        robotX += 1;

                    else if (robotY < 1.0 / 2.0 * (warehouse.mapY - 2) && targetLocation[0, 0] < 1.0 / 2.0 * (warehouse.mapY - 2))
                        robotY--;
                    else if (robotY > warehouse.mapY - 2 && robotX > columnMax)
                        robotX--;
                    else if (robotY > warehouse.mapY - 2 && robotX < columnMax)
                        robotX++;
                    else if (robotY > warehouse.mapY - 2)
                        robotY--;
                    else
                        robotY++;

                }
                else if (robotX > targetLocation[0, 0])
                {
                    if (robotY == 0 || robotY == (warehouse.mapY - 2))
                        robotX -= 1;
                    //else if (robotY == 0 || robotY == warehouse.mapY && robotX > targetLocation[0, 0])
                    //    robotX -= 1;
                    else if (robotY < 1.0 / 2.0 * (warehouse.mapY - 2) && targetLocation[0, 0] < 1.0 / 2.0 * (warehouse.mapY - 2))
                        robotY--;
                    else if (robotY > warehouse.mapY - 2 && robotX > columnMax)
                        robotX--;
                    else if (robotY > warehouse.mapY - 2 && robotX < columnMax)
                        robotX++;
                    else if (robotY > warehouse.mapY - 2)
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

                //critical region check

                criticalCheckFlag = warehouse.criticalRegionCheck(robotX, robotY);
                if (criticalCheckFlag == true)
                {
                    if (flag == true)
                        flag = warehouse.mapRealTimeInfo(robotX, robotY, RobotID);
                }
                else { };

                Console.WriteLine("Robot ID: " + RobotID.ToString() + $" X: {robotX}, Y: {robotY}");
                if (robotY != warehouse.mapY - 1 && flag == false)
                {
                    flag = warehouse.mapRelease(RobotID);
                }
                if (robotX == targetLocation[0, 0] && robotY == targetLocation[0, 1])
                    break;
            }
            xy[0, 0] = robotX;
            xy[0, 1] = robotY;
            return xy;
        }

    }
}
