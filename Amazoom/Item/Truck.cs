using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    public class Truck
    {
        // one or more truck for each order

        public bool isempty;
        public List<int> numofload = new List<int>();
        public List<int> itemontruck = new List<int>();
        // num of load: [2 3 5 6]
        // itemontruck: [1 5 4 7] means this truck have item 1,5,4,7 and the number of them is 2 3 5 6
        public bool isrestock; // true for restocking truck
        public int maxcapacity;
        public int itemsIntruck;

        public Truck(int maxcpacity,int itemsIntruck)
        {
            this.maxcapacity = maxcapacity;
            this.itemsIntruck = itemsIntruck;
        }


        //public Truck(bool empty, List<int> itemontruck, List<int> numofload, bool isrestock)
        //{
        //    this.isempty = empty;
        //    this.itemontruck = itemontruck; //important! the order of itemontruck and numofload must be aligned.
        //    //i.e. [item1 item2] and [50 100] means there are 50 of item1 and 100 of item2 are on the truck
        //    this.numofload = numofload;
        //    this.isrestock = isrestock;
        //}


        //public static bool isready(Truck truckname)
        //{
        //    bool isok = false;
        //    //check if the truck is ready to leave

        //    if (truckname.isrestock == true)
        //    {
        //        isok = checkempty(truckname);
        //    }
        //    else
        //    {
        //        isok = checkfull(truckname);
        //    }
        //    return isok;
        //}



        //public static bool checkempty(Truck truckname)
        //{
        //    bool isempty = false;


        //    if (truckname.numofload.Take(truckname.numofload.Count).Sum() == 0)
        //    {

        //        isempty = true;

        //    }




        //    return isempty;
        //}


        //public static bool checkfull(Truck truckname)
        //{

        //    bool isfull = false;
        //    int capacity = 10; //note this maybe user-dependent or might be changed by the program


        //    if (truckname.numofload.Take(truckname.numofload.Count).Sum() == capacity)
        //    {

        //        isfull = true;

        //    }




        //    return isfull;


        //}


        ///*  public static int totaltime(int[] numofload, bool isrestock) {

        //      int totalt=0;

        //      for (int i = 0; i < numofload.Length; i++) {

        //          if (isrestock)
        //          {
        //              totalt += numofload[i];
        //          }
        //          else {
        //              totalt += numofload[i];

        //          }

        //      }

        //      return totalt;
        //  }*/


        //public static void changeload(Truck truckname, int pickupnum, goods itemtochange, bool isstock)
        //{
        //    //if isstock is true, means it is a restocking truck and we are trying to pickup from the truck, 
        //    //so decrease the goods number from the truck --> and add load to the robot
        //    //how many items and which item is picked up needs to be specified
        //    //if isstock is false, means it is a delivery truck and we are trying to add items to the truck
        //    //so increase the goods --> decrease the load of the robot near it.
        //    //also need to add goods

        //    if (isstock)
        //    {


        //        //robot load ++

        //    }
        //    else
        //    {




        //    }




        //}






    }
}
