using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;
using Amazoom.Item;

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
        bool dockFlag = true;// For delivering
        public int numOfTruck;
        public SemaphoreSlim truckSema = new SemaphoreSlim(1);
        bool flag;
        public List<Truck> truckList;
        public warehouseMapInfo(string mapName, int mapX, int mapY, int[,] dockslocation, int[,] shelvesLocation, List<Truck> Trucklist)
        {
            this.mapX = mapX;
            this.mapY = mapY;
            this.mapName = mapName;
            this.docksLocation = dockslocation;
            this.shelvesLocation = shelvesLocation;
            this.truckList = Trucklist;
            this.numOfTruck = truckList.Count;
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

        public void truckTask(Truck truck,int truckID,int action)
        {
            Console.WriteLine($"*****turck {truckID} : is waiting for the dock********");
            truckSema.Wait();
            Console.WriteLine($"*****turck {truckID} : is going to the dock********");
            Console.WriteLine($"****** turck {truckID} : is waiting for loading********");
            truckList[0].itemsIntruck = truckList[0].maxcapacity;
        }

        public void truckWaitingForLoading(int robotID, int itemsInRobot, int action, int robotMaxCapacity )
        {
            
            /*            if (truckList.Count > 0)
                        {
                            mut.WaitOne();
                            truckList[0].itemsIntruck += itemsInRobot;
                            mut.ReleaseMutex();
                            Console.WriteLine($"Robot ID : {robotID} drops {itemsInRobot} items");
                            Console.WriteLine($"****Items in truck:  { truckList[0].itemsIntruck}****");


                            if (truckList[0].itemsIntruck > truckList[0].maxcapacity)
                            {
                                truckSema.Release();
                                Console.WriteLine($"*********turck is leaving*********");
                                if (truckList.Count > 0)
                                {
                                    truckList.RemoveAt(0);
                                }
                                else
                                {
                                    Console.WriteLine("no more truck is available");
                                }
                            }
                        }
                        */
            //William Edited
            if (action == 1)
            {
                if (truckList.Count > 0)
                {
                    mut.WaitOne();
                    truckList[0].itemsIntruck += itemsInRobot;
                    mut.ReleaseMutex();
                    Console.WriteLine($"Robot ID : {robotID} drops {itemsInRobot} items");
                    Console.WriteLine($"****Items in truck:  { truckList[0].itemsIntruck}****");


                    if (truckList[0].itemsIntruck > truckList[0].maxcapacity)
                    {
                        truckSema.Release();
                        Console.WriteLine($"*********turck is leaving*********");
                        if (truckList.Count > 0)
                        {
                            truckList.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("no more truck is available");
                        }
                    }
                }
            }
            else if (action == 2)
            {
                if (truckList.Count > 0)
                {
                    mut.WaitOne();
                    truckList[0].itemsIntruck -= 1;
                    mut.ReleaseMutex();
                    Console.WriteLine($"Robot ID : {robotID} picks up {itemsInRobot} items");
                    Console.WriteLine($"****Items in truck:  { truckList[0].itemsIntruck}****");

                    if(truckList[0].itemsIntruck == 0)
                    {
                        truckSema.Release();
                        Console.WriteLine($"*********turck is leaving*********");
                        if (truckList.Count > 0)
                        {
                            truckList.RemoveAt(0);
                        }
                        else
                        {
                            Console.WriteLine("no more truck is available");
                        }
                    }
                    
                }
            }
        }
    }
}
