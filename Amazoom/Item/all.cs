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
        goods item2 = new goods(1, "item2", 3, 2);
        goods item3 = new goods(1, "item3", 5, 4);
        goods item4 = new goods(1, "item4", 7, 1);
        goods item5 = new goods(1, "item5", 2, 3);
        goods item6 = new goods(1, "item6", 4, 3);

        List<goods> allItems = new List<goods>();
        List<goods> items = new List<goods>();

        public List<goods> addStocks(int num, int mapX, int mapY)
        {
            int X = 0, Y = 1;

            for(int i = 0; i < num; i++)
            {
                int quantity = 1;
                string name = "item" + i.ToString();

                if (X >= mapX)
                {
                    Y++;
                    X = 1;
                    if (Y > mapY)
                    {
                        Y = 1;
                    }
                }
                else
                {
                    //Y++;
                    X++;
                    if (Y > mapY)
                    {
                        Y = 1;
                        X = 1;
                    }

                    
                }

                items.Add(new goods(quantity, name, X, Y));
            }

            return items;
        }


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


        public List<goods> getAll()
        {
            return allItems;
        }
    }

}
