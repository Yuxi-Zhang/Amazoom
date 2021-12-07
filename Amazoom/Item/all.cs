using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazoom.Item
{
    class all
    {
        public int posX;
        public int posY;
        public string name;


        goods item1 = new goods(1, "item1", 1, 1);
        goods item2 = new goods(1, "item1", 3, 2);
        goods item3 = new goods(1, "item1", 5, 4);
        goods item4 = new goods(1, "item1", 7, 1);
        goods item5 = new goods(1, "item1", 2, 3);
        goods item6 = new goods(1, "item1", 4, 3);

        List<goods> allItems = new List<goods>();

        public void Initialize()
        {
            allItems.Add(item1);
            allItems.Add(item2);
            allItems.Add(item3);
            allItems.Add(item4);
            allItems.Add(item5);
            allItems.Add(item6);
        }

        public List<goods> addItems(int num, string name, int x, int y)
        {
            allItems.Add(new goods(num, name, x, y));
            return allItems;
        }
    }

}
