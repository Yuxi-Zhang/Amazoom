//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Threading;
//using System.Collections.Concurrent;
//using System.Threading.Tasks;

//namespace Amazoom.Item
//{
//    public class dock
//    {
//        public static ConcurrentQueue<Truck> restocklist = new ConcurrentQueue<Truck>();
//        public static ConcurrentQueue<Truck> deliverylist = new ConcurrentQueue<Truck>();
//        // ConcurrentQueue<T>.Enqueue()
//        // ConcurrentQueue<T>.TryPeek()
//        // ConcurrentQueue<T>.TryDequeue()


//        //when a new truck come, equeue it
//        //not sure


//        private static Semaphore _restockcome;//ideally it is the user to input this like how many spots avaliable for truck to stay
//        private static Semaphore _loadcome; //the user need to input the number of max semaphore;


//        //if semaphore is free, dequeue the truck accordingly and wait until the truck is empty




//        //logic:
//        // restock comes --> in queue  --> unloading -->uploading --> leave -->one position becomes possible
//        // delivery comes --> inqueue --> unloading --> leave --> one position becomes possible
//        /*     for (int i = 1; i <= docknum; i++)
// {
//     Thread t = new Thread( );

//     t.Start(i);
// }
//*/

//        public static void Truckcomes(Truck truck)
//        {
//            //when truckcomes, it would be set in the waiting line i.e. the concurrent queue.
//            //if there is any empty spot, it would be dequeued and the semaphore is locked.
//            //when 'truckleave' the semaphore is released.

//            if (truck.isrestock)
//            {

//                restocklist.Enqueue(truck);
//            }
//            else
//            {
//                deliverylist.Enqueue(truck);
//            }


//        }


//        public static void processtruck(ConcurrentQueue<Truck> restocklist, ConcurrentQueue<Truck> deliverylist, int ddock, int rdock)
//        {
//            // ddcok and rdock is the maximum docks avaliable for delivery or restock - layout dependent
//            _restockcome = new Semaphore(0, rdock);//ideally it is the user to input this like how many spots avaliable for truck to stay
//            _loadcome = new Semaphore(0, ddock);
//            Truck currenttruck;
//            Task[] tasks = new Task[5];



//            for (int i = 1; i <= ddock + rdock; i++)
//            {

//                if (restocklist.Count > deliverylist.Count)
//                {
//                    restocklist.TryDequeue(out currenttruck);
//                }
//                else
//                {
//                    deliverylist.TryDequeue(out currenttruck);


//                }

//                tasks[i] = Task.Run(() =>
//                {
//                    truckleave(currenttruck);
//                });
//            }



//        }




//        //the robot will change the number of load on delivery or restocking truck
//        //function truckleave is just to check the if the truck is ready to leave every 10ms
//        public static void truckleave(Truck truck)
//        {
//            if (Truck.isready(truck))
//            {

//                if (truck.isrestock)
//                {
//                    Console.WriteLine("a restocking truck is in dock");
//                    _restockcome.WaitOne(1);

//                }
//                else
//                {
//                    Console.WriteLine("a delivery truck is in dock");
//                    _loadcome.WaitOne(1);
//                }
//            }

//            while (true)
//            {
//                Thread.Sleep(10);

//                // when truck is ready to leave, release the semaphore


//                if (Truck.isready(truck))
//                {

//                    if (truck.isrestock)
//                    {
//                        Console.WriteLine("a restocking truck is leaving");
//                        _restockcome.Release(1);

//                    }
//                    else
//                    {
//                        Console.WriteLine("a delivery truck is leaving");
//                        _loadcome.Release(1);
//                    }
//                    return;
//                }
//            }
//        }






//    }
//}
