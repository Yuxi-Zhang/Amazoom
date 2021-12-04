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

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Home());

            int robotNumber = 5;
            int i;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 8, 5, new int[,] { { 2, 5 }, { 3, 5 } }, new int[,] { { 1, 2 }, { 8, 4 } });

            List<robot> robotList = new List<robot>();
            var itemListMaster = new List<List<int[,]>>();

            // create a list for robots

            for (i = 0; i < robotNumber; i++)
            {
                robot bot = new robot(6, 1, warehouse1);
                robotList.Add(bot);
            }

            int[,] items = new int[4, 2] { { 1, 2 }, { 1, 3 }, { 2, 3 }, { 2, 5 } };

            // create a list for robot item lists
            for (i = 0; i < robotNumber; i++)
            {
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }

            // could do a test here
            for (i = 0; i < robotNumber; i++)
            {
                if (1 <= items[i, 0] && items[i, 0] <= 2)
                {
                    itemListMaster[0].Add(new int[,] { { items[i, 0], items[i, 1] } });
                }
                else if (3 <= items[i, 0] && items[i, 0] <= 4)
                {
                    itemListMaster[1].Add(new int[,] { { items[i, 0], items[i, 1] } });
                }
                else if (5 <= items[i, 0] && items[i, 0] <= 6)
                {
                    itemListMaster[2].Add(new int[,] { { items[i, 0], items[i, 1] } });
                }
                else if (7 <= items[i, 0] && items[i, 0] <= 8)
                {
                    itemListMaster[3].Add(new int[,] { { items[i, 0], items[i, 1] } });
                }
            }

            //spin multi-threading
            for (i = 0; i < robotNumber; i++)
            {
                Thread thread = new Thread(() =>
                {
                    robotList[i].findRoute(itemListMaster[i]);
                });
            }
        }
    }
}
