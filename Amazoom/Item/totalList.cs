using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace Amazoom.Item
{
    public class totallist
    {



        //  public volatile static List<inventory> maintest.storage = new List<inventory>();
        //public volatile static int[,] itempos = new int[ 1, 1];  

        public static List<int[,]> sort()
        {
            List<int[,]> sorted = new List<int[,]>();






            return sorted;

        }


        public static List<int[,]> poslist(List<goods> total)
        {
            List<int[,]> fulllist = new List<int[,]>();
            int[,] itempos = new int[1, 2];


            for (int i = 0; i < total.Count; i++)
            {

                itempos = findpos(total[i]);
                fulllist.Add(itempos);

            }





            return fulllist;
        }

        public static int[,] findpos(goods theitem)
        {
            int[,] position = new int[1, 2];
            int index = -1;
            for (int i = 0; i < maintest.storage.Count; i++)
            {

                if (maintest.storage[i].item == theitem)
                {

                    index = i;

                }
            }
            if (index == -1)
            {
                position[0, 0] = -1;
                position[0, 1] = -1;
                return position;

            }

            if (index >= 0)
            {
                for (int check = 0; check < maintest.storage[index].specificnum.Count; check++)
                {
                    if (maintest.storage[index].specificnum[check] <= 0)
                    {
                        maintest.storage[index].specificnum.RemoveAt(check);
                        maintest.storage[index].posx.RemoveAt(check);
                        maintest.storage[index].posy.RemoveAt(check);
                        check--;
                    }
                }
            }

            // int[,] itempos = new int[1, 1];


            for (int j = 0; j < maintest.storage.Count; j++)
            {



                if (maintest.storage[j].item == theitem)
                {
                    // for (int j = 0; j < maintest.storage[i].posx.Count; j++)

                    //      int num = 0;

                    //  py = maintest.storage[i].posy[j];
                    // px = maintest.storage[i].posx[j];
                    // itempos.SetValue(maintest.storage[i].posx[j], maintest.storage[i].posy[j]);
                    // for(int t = maintest.storage[i].posx.Count-1; t <0 ; t--) {

                    // if (maintest.storage[i].specificnum[t] > 0) { 

                    if (maintest.storage[j].posx.Count > 0)
                    {
                        position[0, 0] = maintest.storage[j].posx[0];
                        position[0, 1] = maintest.storage[j].posy[0];
                    }
                    else
                    {
                        position[0, 0] = -1;
                        position[0, 1] = -1;
                        maintest.storage.RemoveAt(j);
                        //remove the item since it is not in the inventory at any position

                    }

                    //  }
                    //}

                    //position.SetValue(maintest.storage[i].posx[0], maintest.storage[i].posy[0]);

                }



            }

            // position should be a list containing all possible positions of the item
            //e.g. [2,3],[3,4] in some order as it is placed in the inventory

            return position;

        }


        //everytime new good is add just add in this inventory list;
        public static int getinventory(goods theitem, int numneed, int needx, int needy)
        {

            int moreneed = 0;
            int index = -1;
            int indexpos = -1;

            for (int i = 0; i < maintest.storage.Count; i++)
            {

                if (maintest.storage[i].item == theitem)
                {

                    index = i;

                }
            }
            if (index >= 0)
            {
                for (int check = 0; check < maintest.storage[index].specificnum.Count; check++)
                {
                    if (maintest.storage[index].specificnum[check] <= 0)
                    {
                        maintest.storage[index].specificnum.RemoveAt(check);
                        maintest.storage[index].posx.RemoveAt(check);
                        maintest.storage[index].posy.RemoveAt(check);
                        check--;
                    }
                }

                if (maintest.storage[index].posx.Count <= 0)
                {

                }
                else
                {

                    maintest.storage.RemoveAt(index);

                    //remove the item since it is not in the inventory at any position

                }
            }
            //the position and number of the item needed must be specified.
            //if not enough items are at that spot or the item is not at that spot, return the number of items that are further needed.

            for (int i = 0; i < maintest.storage.Count; i++)
            {

                if (maintest.storage[i].item == theitem)
                {

                    index = i;

                }
            }

            if (index == -1)
            {
                return numneed; //means the item does not even exist

            }
            else
            {
                //warning: posx and posy both contains does not means it contains the specific point.
                // i.e. (2,3) and (3,4) does not imply it contains (2,4)
                for (int j = 0; j < maintest.storage.Count; j++)
                {

                    if (maintest.storage[index].posx[j] == needx && maintest.storage[index].posy[j] == needy)
                    {
                        indexpos = j;
                    }
                }
                //note: x and y must match at the same time
                if (indexpos == -1)
                {
                    //item exist but the position is different than command location

                    return numneed;

                }
                else
                {

                    if (maintest.storage[index].specificnum[indexpos] > numneed)
                    {
                        maintest.storage[index].specificnum[indexpos] -= numneed;
                        return 0;

                    }
                    else
                    {
                        int diff = numneed - maintest.storage[index].specificnum[indexpos];


                        moreneed = diff;



                        maintest.storage[index].posx.RemoveAt(indexpos);

                        maintest.storage[index].posy.RemoveAt(indexpos);

                        maintest.storage[index].specificnum.RemoveAt(indexpos);





                        return diff;

                    }

                }







                //  return numneed;


            }

        }



        public static void addinventory(goods theitem, int numadd, int addx, int addy)
        {
            int index = -1;
            int indexpos = -1;
            List<int> newposx = new List<int>();
            List<int> newposy = new List<int>();
            List<int> newspecificnum = new List<int>();
            newposx.Add(addx);
            newposy.Add(addy);


            for (int i = 0; i < maintest.storage.Count; i++)
            {

                if (maintest.storage[i].item == theitem)
                {

                    index = i;
                    maintest.storage[i].totalinv += numadd;

                }
            }

            if (index == -1)
            {

                inventory newstuff = new inventory(theitem, numadd, newposx, newposy, newspecificnum);

                maintest.storage.Add(newstuff);
                //add this new stuff to it

            }
            else //if it exist, find where it is and add the specific number of it
            {//we already find the index of the goods, but we need to find where it is located.
             //in case it is located at multiple shelf due to weight capacity


                if (maintest.storage[index].posx.Contains(addx) && maintest.storage[index].posx.Contains(addy))
                {//warning: posx and posy both contains does not means it contains the specific point.
                 // i.e. (2,3) and (3,4) does not imply it contains (2,4)
                    for (int j = 0; j < maintest.storage.Count; j++)
                    {

                        if (maintest.storage[index].posx[j] == addx && maintest.storage[index].posy[j] == addy)
                        {
                            indexpos = j;
                            //note: x and y must match at the same time
                            maintest.storage[index].specificnum[j] += numadd;

                        }



                    }
                    if (indexpos == -1)
                    {
                        //item exist but the position is different than current location
                        maintest.storage[index].posx.Add(addx);
                        maintest.storage[index].posy.Add(addy);
                        maintest.storage[index].specificnum.Add(numadd);


                    }

                }

            }

        }

        //   public goods[] goodslist = new goods[5];
        /*    static void Main(string[] args)
            {
                Console.WriteLine("Hello World!");
            }
        */


        public void loading(int itemnum)
        {

            //   goodslist[itemnum].number++;
            // while loading, do we want to add weight?



        }

        public void ordering(int itemnum, int ordernumber)
        {
            //    goodslist[itemnum].ordernum = ordernumber;

        }


        public void removing(int itemnum)
        {
            // goodslist[itemnum].number--;


        }







    }
}




