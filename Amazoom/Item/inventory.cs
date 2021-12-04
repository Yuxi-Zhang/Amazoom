using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    public class inventory
    {
        public goods item; //every item
        public List<int> posx = new List<int>();
        public List<int> posy = new List<int>();
        // public List<int[]> positions = new List<int[]>();
        public List<int> specificnum = new List<int>(); // the specific num of goods at specific position
        public int totalinv;

        //    public static List<int> newposx = new List<int>();
        //     public static List<int> newposy = new List<int>();
        //   public static List<int> newspecificnum = new List<int>();


        /*  List<int> myInts = new List<int>();
            myInts.Add(5);
            myInts.Add(10);
            myInts.Add(11);
            myInts.Count // = 3*/
        // 11   23       10 20


        public inventory(goods item, int totalinv, List<int> posx, List<int> posy, List<int> specificnum)
        {
            this.item = item;
            this.totalinv = totalinv;
            this.posx = posx;
            this.posy = posy;
            this.specificnum = specificnum;
            this.totalinv = specificnum.Take(specificnum.Count).Sum();//totalinv should be the sum of all the specific numebrs


        }

    }
}
