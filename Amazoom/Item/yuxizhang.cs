/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    class Program
    {
        static void Main()
        {

            List<int> testx = new List<int>();
            List<int> testy = new List<int>();
            List<int> testsn = new List<int>();
            int williamzhang = 0;

            testx.Add(1);
            testx.Add(2);

            testy.Add(5);
            testy.Add(3);

            testsn.Add(1);
            testsn.Add(1);

            goods testitem = new goods(1, "YuxiZhang", 100, null, null);
            totallist.addinventory(testitem, 1, 321, 123);
            williamzhang = totallist.getinventory(testitem, 1, 321, 123);
            totallist.addinventory(testitem, 1, 58, 100);
            int[,] testfind = new int[1, 2];

            testfind = totallist.findpos(testitem);


            Console.WriteLine("{0},{1}\n {2}", testfind[0, 0], testfind[0, 1], williamzhang);
            Thread.Sleep(30000);
            Console.WriteLine("{0},{1}\n {2}", testfind[0, 0], testfind[0, 1], williamzhang);


            //test upload some goods with [1,2,3,4,5] and [5,4,3,2,1] and the bay only allow one truck at a time;



        }
    }
}*/