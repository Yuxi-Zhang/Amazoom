using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazoom.Item
{
    public class goods
    {

        public double num;
        public string goodsname;
        public double positionx;
        public double positiony; // (-1,-1 means on truck)
        public double size; //volume
        public double weight;
        public double number; //number remaining in the warehouse;
        public int ordernum;

        public goods(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum)
        {

            this.num = num;
            this.goodsname = goodsname;
            this.positionx = x;
            this.positiony = y;
            this.size = size;
            this.weight = weight;
            this.number = number;
            this.ordernum = ordernum;

        }

    }

    public class item1 : goods
    {

        public item1() : base(0, " ", -1, -1, 0, 0, 0, -1) //order number = -1 means not ordered
        {

        }
        public item1(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum) : base(num, goodsname, x, y, size, weight, number, ordernum)
        {

        }
    }

    public class item2 : goods
    {

        public item2() : base(0, " ", -1, -1, 0, 0, 0, -1) //order number = -1 means not ordered
        {

        }
        public item2(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum) : base(num, goodsname, x, y, size, weight, number, ordernum)
        {

        }
    }
    public class item3 : goods
    {

        public item3() : base(0, " ", -1, -1, 0, 0, 0, -1) //order number = -1 means not ordered
        {

        }
        public item3(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum) : base(num, goodsname, x, y, size, weight, number, ordernum)
        {

        }
    }
    public class item4 : goods
    {

        public item4() : base(0, " ", -1, -1, 0, 0, 0, -1) //order number = -1 means not ordered
        {

        }
        public item4(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum) : base(num, goodsname, x, y, size, weight, number, ordernum)
        {

        }
    }

    public class item5 : goods
    {

        public item5() : base(0, " ", -1, -1, 0, 0, 0, -1) //order number = -1 means not ordered
        {

        }
        public item5(double num, string goodsname, double x, double y, double size, double weight, double number, int ordernum) : base(num, goodsname, x, y, size, weight, number, ordernum)
        {

        }
    }
}
