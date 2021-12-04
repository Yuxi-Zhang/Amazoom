using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Amazoom.Item
{
    class dock
    {
        private static Semaphore _pool;

        public static void run()
        {

            _pool = new Semaphore(0, 3);

            //logic:
            // delivery comes --> in queue  --> unloading -->uploading --> leave -->one position becomes possible





        }


        public static void restock(Truck truckname)
        {

            int[] goodsl = new int[5];
            int[] goodsadd = new int[5];
            goodsadd = Truck.upload(truckname);
            //storage
            for (int i = 0; i < 5; i++)
                goodsl[i] += goodsadd[i];

        }

        public void delivery()
        {
        }
    }
}
