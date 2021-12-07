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

        public void run (List<string[]> requst, int action)
        {
            //Application.EnableVisualStyles();
            //Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new Home());


            // Intialize new items 
            goods item1 = new goods(100, "apple", 1, null, null, 1, 3);
            goods item2 = new goods(100, "pear", 1, null, null, 1, 4);
            goods item3 = new goods(100, "pineapple", 1, null, null, 2, 2);
            goods item4 = new goods(100, "pipe", 1, null, null, 3, 4);
            goods item5 = new goods(100, "sensor", 1, null, null, 2, 5);

            List<string[]> toCustomer = new List<string[]>();

            toCustomer.Add(new string[] { item1.goodsname, item1.num.ToString()});
            toCustomer.Add(new string[] { item2.goodsname, item2.num.ToString() });
            toCustomer.Add(new string[] { item3.goodsname, item3.num.ToString() });
            toCustomer.Add(new string[] { item4.goodsname, item4.num.ToString() });
            toCustomer.Add(new string[] { item5.goodsname, item5.num.ToString() });


            int robotNumber = 5;
            int i = 0;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 8, 8, new int[,] { { 2, 7 }, { 3, 7 } }, new int[,] { { 1, 2 }, { 8, 4 } });
            //(0-7)(0-6)

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
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }

            

            List<Thread> threadList = new List<Thread>();
            //spin multi-threading
            for (i = 0; i < robotNumber; i++)
            {
                int temp = i;
                Thread thread = new Thread(() =>
                {
                    robotList[temp].findRoute(itemListMaster[temp], 1);

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