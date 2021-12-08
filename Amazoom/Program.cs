﻿using Amazoom.Motion;
using Amazoom.Item;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Windows.Forms;

namespace Amazoom
{
    class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        //[STAThread]
        public ConcurrentQueue<int[,]> itemQ = new ConcurrentQueue<int[,]>();
        public Random rnd = new Random();
        public List<int[,]> itemList = new List<int[,]>();
        public List<robot> robotList = new List<robot>();
        public List<List<int[,]>> itemListMaster = new List<List<int[,]>>();

        public void run (List<int[,]> requst, int action)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());
            
            int robotNumber = 5;
            int i = 0;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 9, 9, new int[,] { { 2, 7 }, { 3, 7 } }, new int[,] { { 1, 2 }, { 8, 4 } });
            //(0-7)(0-6)

           

            // create a list for robots
            double temp2 = (double)warehouse1.mapX / robotNumber;
            int column;
            column = Convert.ToInt32(temp2); 
            
            //if((temp2 - column) > 0.5)
            //{
            //    temp2 = temp2 + 1;
            //}

            for (i = 0; i < robotNumber; i++)
            {
                if (i != robotNumber - 1)
                {
                    robot bot = new robot(6, 1, warehouse1, i + 1, i * column, (i + 1) * column - 1);
                    robotList.Add(bot);
                }
                else
                {
                    robot bot = new robot(6, 1, warehouse1, i + 1, i * column, warehouse1.mapX-1);
                    robotList.Add(bot);
                }
            }

            for (i = 0; i < robotNumber; i++)
            {
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }

            //sort list and assign them to different small list
            while(requst.Count != 0)
            {
                for (i = 0; i < robotNumber; i++) {

                    int ti = i;
                    if (requst[0][0,0] >= robotList[i].columnMin && requst[0][0, 0] <= robotList[i].columnMax)
                    {
                        int[,] temp = requst[0]; 
                        itemListMaster[i].Add(temp);
                        requst.RemoveAt(0);
                        Console.WriteLine($"item assigned to robot{i}");
                            break;
                    }
                    if (requst[0][0, 0] > warehouse1.mapX )
                    {
                        Console.WriteLine($"item is not validate");
                        break;
                    }


                }

            }

            List<Thread> threadList = new List<Thread>();
            //spin multi-threading
            for (i = 0; i < robotNumber; i++)
            {
                int temp = i;
                Thread thread = new Thread(() =>
                {
                    robotList[temp].findRoute(itemListMaster[temp], action);

                });
                thread.Start();
                threadList.Add(thread);
            }

            for (i = 0; i < robotNumber; i++)
            {
                threadList[i].Join();
            }
            Thread.Sleep(10000000);
        }
    }
}