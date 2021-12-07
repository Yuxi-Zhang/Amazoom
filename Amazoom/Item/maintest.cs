/*using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    class maintest
    {
        public volatile static List<inventory> storage = new List<inventory>();
        static void Main()
        {



            List<int> testx = new List<int>();
            List<int> testy = new List<int>();
            List<int> testsn = new List<int>();

            testx.Add(1);
            testx.Add(2);

            testy.Add(5);
            testy.Add(3);

            testsn.Add(0);
            testsn.Add(2);
            goods baditem = new goods(2, "HT", 120, null, null);
            goods testitem = new goods(1, "YuxiZhang", 100, null, null);
            //    totallist.addinventory(testitem, 100, 321, 123);
            //   totallist.getinventory(testitem, 1, 321, 123);
            totallist.addinventory(testitem, 1, 58, 100);
            inventory fist = new inventory(testitem, 2, testx, testy, testsn);
            // storage.Add(fist);
            //   totallist.getinventory(testitem, 1, 321, 123);
            //totallist.getinventory(testitem, 1, 321, 123);
            int thisone = storage[0].specificnum[0];
            int damn = totallist.getinventory(testitem, 1, 58, 100);
            //totallist.getinventory(baditem, 1, 1, 1);
            int[,] testfind = totallist.findpos(testitem);

            Console.WriteLine("{0},{1}", testfind[0, 0], testfind[0, 1]);
            Console.WriteLine("{0}", thisone);
            Console.WriteLine("{0}", damn);


            //test upload some goods with [1,2,3,4,5] and [5,4,3,2,1] and the bay only allow one truck at a time;



        }
    }
}
*/