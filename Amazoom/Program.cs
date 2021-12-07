using Amazoom.Motion;
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

        public void run (List<int[,]> requst, int action)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());
            
            int robotNumber = 5;
            int i = 0;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 8, 8, new int[,] { { 2, 7 }, { 3, 7 } }, new int[,] { { 1, 2 }, { 8, 4 } });
            //(0-7)(0-6)

            List<int[,]> itemList = new List<int[,]>();
            List<robot> robotList = new List<robot>();
            var itemListMaster = new List<List<int[,]>>();

            // create a list for robots
            int column = warehouse1.mapX % robotNumber;
            for (i = 0; i < robotNumber; i++)
            {
                if (i != robotNumber - 1)
                {
                    robot bot = new robot(6, 1, warehouse1, i + 1, i * column, (i + 1) * column - 1);
                    robotList.Add(bot);
                }
                else
                {
                    robot bot = new robot(6, 1, warehouse1, i + 1, i * column, warehouse1.mapX);
                    robotList.Add(bot);
                }
            }

            for (i = 0; i < robotNumber; i++)
            { 
                itemListMaster.Add(itemList);
            }

            //sort list and assign them to different small list
            while(requst.Count != 0)
            {
                for (i = 0; i < robotNumber; i++) {
                    if (requst[0][0,0] >= robotList[i].columnMin && requst[0][0, 0] <= robotList[i].columnMax)
                    {
                        itemListMaster[i].Add((requst[0]));
                        requst.RemoveAt(0);
                        if (requst.Count <= 0)
                        {
                            break;
                        }
                    }
                    else
                    {
                        Console.WriteLine("the item is not validate");
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
        }
    }
}