using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Amazoom.Item
{
    public class Truck
    {
        public bool isempty;
        public int[] numofload = new int[5];
        // [0 1 0 0 0 ] means this truck only have item2 number is 1
        public bool isload;
        public Truck(bool empty, int[] numofload, bool isload)
        {

            this.isempty = empty;
            this.numofload = numofload;
            this.isload = isload;
        }


        public static int totaltime(int[] numofload, bool isload)
        {

            int totalt = 0;

            for (int i = 0; i < numofload.Length; i++)
            {

                if (isload)
                {
                    totalt += numofload[i];
                }
                else
                {
                    totalt += numofload[i];

                }

            }

            return totalt;
        }


        public static int[] upload(Truck truckname)
        {
            int[] restocking = new int[5];
            for (int i = 0; i < 5; i++)
            {
                restocking[i] = truckname.numofload[i];
            }
            return restocking;
        }






    }



    public class bay
    {

        public int slots;
        public int loadingtime;
        public int unloadingtime;

    }
}
