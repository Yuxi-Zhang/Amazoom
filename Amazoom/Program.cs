﻿/*using System;
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

            int robotNumber = 4;
            int i;
            warehouseMapInfo warehouse1 =
            new warehouseMapInfo("warehouse1", 8, 5, new int[,] { { 2, 5 }, { 3, 5 } }, new int[,] { { 1, 2 }, { 8, 4 } });

            List<robot> robotList = new List<robot>();
            var itemListMaster = new List<List<int[,]>>();

            // create a list for robots
            int column = warehouse1.mapX % robotNumber;
            for (i = 0; i < robotNumber; i++)
            {
                if (i != robotNumber - 1)
                {
                    robot bot = new robot(6, 1, warehouse1, i * column, (i + 1) * column - 1);
                    robotList.Add(bot);
                }
                else
                {
                    robot bot = new robot(6, 1, warehouse1, i * column, warehouse1.mapX);
                    robotList.Add(bot);
                }
            }

           

            Console.WriteLine("main is working");

<<<<<<< HEAD
            //// create a list for robot item lists
            for (i = 0; i < robotNumber; i++)
            {
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }

            itemListMaster[0].Add(new int[,] { { 1, 1 }, { 1, 5 }, { 2, 1 }, { 2, 5 } });
            itemListMaster[1].Add(new int[,] { { 3, 1 }, { 3, 5 } });
            itemListMaster[2].Add(new int[,] { { 6, 2 }, { 6, 3 }, { 6, 5 } });
            itemListMaster[3].Add(new int[,] { { 7, 1 }, { 7, 2 }, { 7, 3 }, { 7, 4 }, { 7, 5 }, { 8, 3 }, { 8, 5 } });
=======
            // create a list for robot item lists
            *//*for (i = 0; i < robotNumber; i++)
            {
                List<int[,]> itemList = new List<int[,]>();
                itemListMaster.Add(itemList);
            }*//*
>>>>>>> 492d70a8e0e6ff03bb3431ef26f2bd5f88e5a7b4

            // could do a test here
            for (i = 0; i < robotNumber; i++)
            {
                *//*if (1 <= items[i, 0] && items[i, 0] <= 2)
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
                }*//*

                // Test 1, 随机

                // Test 2, 所有机器人所有位置都要拿东西
                //itemListMaster[0].Add(new int[,] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 2, 4 }, { 2, 5 } });
                //itemListMaster[1].Add(new int[,] { { 3, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 }, { 3, 5 }, { 4, 1 }, { 4, 2 }, { 4, 3 }, { 4, 4 }, { 4, 5 } });
                //itemListMaster[2].Add(new int[,] { { 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 4 }, { 5, 5 }, { 6, 1 }, { 6, 2 }, { 6, 3 }, { 6, 4 }, { 6, 5 } });
                //itemListMaster[3].Add(new int[,] { { 7, 1 }, { 7, 2 }, { 7, 3 }, { 7, 4 }, { 7, 5 }, { 8, 1 }, { 8, 2 }, { 8, 3 }, { 8, 4 }, { 8, 5 } });

                //// Test 3, 只有一个机器人工作
                //itemListMaster[0].Add(new int[,] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 2, 4 }, { 2, 5 } });
                //itemListMaster[1].Add(new int[,] {});
                //itemListMaster[2].Add(new int[,] {});
                //itemListMaster[3].Add(new int[,] {});

                //// Test 4, 只有一个机器人没有工作
                //itemListMaster[0].Add(new int[,] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 1, 4 }, { 1, 5 }, { 2, 1 }, { 2, 2 }, { 2, 3 }, { 2, 4 }, { 2, 5 } });
                //itemListMaster[1].Add(new int[,] { { 3, 1 }, { 3, 2 }, { 3, 3 }, { 3, 4 }, { 3, 5 }, { 4, 1 }, { 4, 2 }, { 4, 3 }, { 4, 4 }, { 4, 5 } });
                //itemListMaster[2].Add(new int[,] { { 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 4 }, { 5, 5 }, { 6, 1 }, { 6, 2 }, { 6, 3 }, { 6, 4 }, { 6, 5 } });
                //itemListMaster[3].Add(new int[,] {});

                //// Test 5, 有的机器人没有工作, 有的随机拿
                //itemListMaster[0].Add(new int[,] { { 1, 1 }, { 1, 2 }, { 1, 3 }, { 2, 5 } });
                //itemListMaster[1].Add(new int[,] {});
                //itemListMaster[2].Add(new int[,] { { 5, 1 }, { 5, 2 }, { 5, 3 }, { 5, 4 }, { 5, 5 }, { 6, 1 }, { 6, 2 }, { 6, 3 }, { 6, 4 }, { 6, 5 } });
                //itemListMaster[3].Add(new int[,] { { 7, 1 }, { 7, 5 }, { 8, 1 }, { 8, 5 } });

                //// Test 6, 
                //itemListMaster[0].Add(new int[,] {});
                //itemListMaster[1].Add(new int[,] { { 3, 1 }});
                //itemListMaster[2].Add(new int[,] { { 5, 1 }, { 5, 3 }, { 5, 5 }, { 6, 2 }, { 6, 4 } });
                //itemListMaster[3].Add(new int[,] {});

            }

            for (i = 0; i < robotNumber; i++)
            {

            }

            //spin multi-threading
            for (i = 0; i < robotNumber; i++)
            {
                Thread thread = new Thread(() =>
                {
                    robotList[i].findRoute(itemListMaster[i]);
                });
                thread.Start();
                thread.Join();
            }
        }
    }
}
*/