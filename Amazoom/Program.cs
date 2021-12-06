using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Concurrent;
using System.Threading;
using Amazoom.Motion;

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

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

            int robotNumber = 5;
            int i = 0;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 8, 6, new int[,] { { 2, 6 }, { 3, 6 } }, new int[,] { { 1, 2 }, { 8, 4 } });

            List<robot> robotList = new List<robot>();
            var itemListMaster = new List<List<int[,]>>();

            // create a list for robots
            int column = warehouse1.mapX % robotNumber;
            for (i = 0; i < robotNumber; i++)
            {
                if (i != robotNumber - 1)
                {
                    robot bot = new robot(1, 1, warehouse1, i + 1, i * column, (i + 1) * column - 1);
                    robotList.Add(bot);
                }
                else
                {
                    robot bot = new robot(1, 1, warehouse1, i + 1, i * column, warehouse1.mapX);
                    robotList.Add(bot);
                }
            }

            for (i = 0; i < robotNumber; i++)
            {
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }

            itemListMaster[0].Add(new int[,] { { 1, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 4 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 5 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 1, 0 } });

            itemListMaster[0].Add(new int[,] { { 1, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 4 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 5 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 1, 0 } });

            itemListMaster[0].Add(new int[,] { { 1, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 4 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 5 } });
            itemListMaster[0].Add(new int[,] { { 0, 1 } });
            itemListMaster[0].Add(new int[,] { { 1, 2 } });
            itemListMaster[0].Add(new int[,] { { 1, 0 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 4 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 5 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 0 } });
            itemListMaster[1].Add(new int[,] { { 3, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 4 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 5 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 0 } });
            itemListMaster[1].Add(new int[,] { { 3, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 4 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 1 } });
            itemListMaster[1].Add(new int[,] { { 3, 5 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 } });
            itemListMaster[1].Add(new int[,] { { 2, 2 } });
            itemListMaster[1].Add(new int[,] { { 2, 0 } });
            itemListMaster[1].Add(new int[,] { { 3, 2 } });

            itemListMaster[1].Add(new int[,] { { 3, 1 }, { 3, 5 } });
            itemListMaster[2].Add(new int[,] { { 6, 2 }, { 6, 3 }, { 6, 5 } });
            itemListMaster[3].Add(new int[,] { { 7, 1 }, { 7, 2 }, { 7, 3 }, { 7, 4 }, { 7, 5 }, { 8, 3 }, { 8, 5 } });

            List<Thread> threadList = new List<Thread>();
            //spin multi-threading
            for (i = 0; i < robotNumber; i++)
            {
                int temp = i;
                Thread thread = new Thread(() =>
                {
                    robotList[temp].findRoute(itemListMaster[temp]);

                });

                thread.Start();
                threadList.Add(thread);
            }


            for (i = 0; i < robotNumber; i++)
            {
                //threadList[i].Start();
                threadList[i].Join();
            }
        }
    }
}