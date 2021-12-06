using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    public class goods
    {
        //this just defines the basics of an item.
        //the total inventory of the item is defined in inventory class
        public int num;
        public string goodsname;
        //    public int positionx;
        //    public int positiony; // (-1,-1 means on truck)
        //    public int size; //volume
        public int weight;
        public List<int> number = new List<int>(); //number ordered;
        public List<int> ordernum = new List<int>();

        public goods(int num, string goodsname, int weight, List<int> number, List<int> ordernum)
        {

            this.num = num;
            this.goodsname = goodsname;
            this.weight = weight;

            this.number = number;// number to determine the order of online orders
            this.ordernum = ordernum;

        }

    }
    /*
            public class item1 : goods
            {

                public item1() : base(0, " ",0,0,-1) //order number = -1 means not ordered
                {

                }
                public item1(int num, string goodsname, int weight, int number, int ordernum) : base(num, goodsname, weight, number,ordernum)
            {

                }
            }

        public class item2 : goods
        {

            public item2() : base(0, " ", 0, 0, -1) //order number = -1 means not ordered
            {

            }
            public item2(int num, string goodsname, int weight, int number, int ordernum) : base(num, goodsname, weight, number, ordernum)
            {

            }
        }
        public class item3 : goods
        {

            public item3() : base(0, " ", 0, 0, -1) //order number = -1 means not ordered
            {

            }
            public item3(int num, string goodsname, int weight, int number, int ordernum) : base(num, goodsname, weight, number, ordernum)
            {

            }
        }
        public class item4 : goods
        {

            public item4() : base(0, " ", 0,  0, -1) //order number = -1 means not ordered
            {

            }
            public item4(int num, string goodsname,  int weight, int number, int ordernum) : base(num, goodsname, weight, number, ordernum)
            {

            }
        }

        public class item5 : goods
        {

            public item5() : base(0, " ", 0,  0, -1) //order number = -1 means not ordered
            {

            }
            public item5(int num, string goodsname, int weight, int number, int ordernum) : base(num, goodsname, weight, number, ordernum)
            {

            }
        }*/



}
