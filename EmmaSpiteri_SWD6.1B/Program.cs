using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmmaSpiteri_SWD6._1B
{
    class Program
    {
        static void Main(string[] args)
        {
            long time_1000Elements_Array = timeDoublyLinkList(10000, 1000);
            long time_10000Elements_Array = timeDoublyLinkList(10000, 10000);
            long time_100000Elements_Array = timeDoublyLinkList(10000, 100000);
            long time_1000000Elements_Array = timeDoublyLinkList(10000, 1000000);

            Console.WriteLine("Doubly Link List: ");
            Console.WriteLine("Size : 1000 \tTime : " + time_1000Elements_Array);
            Console.WriteLine("Size : 10000 \tTime : " + time_10000Elements_Array);
            Console.WriteLine("Size : 100000 \tTime : " + time_100000Elements_Array);
            Console.WriteLine("Size : 100000 \tTime : " + time_1000000Elements_Array);

            long time_100Elements_Singly = timeSinglyLinkedList(10000, 1000);
            long time_1000Elements_Singly = timeSinglyLinkedList(10000, 10000);
            long time_10000Elements_Singly = timeSinglyLinkedList(10000, 100000);
            long time_100000Elements_Singly = timeSinglyLinkedList(10000, 1000000);

            Console.WriteLine("\n\nSingly Linked List : ");
            Console.WriteLine("Size : 100 \tTime : " + time_100Elements_Singly);
            Console.WriteLine("Size : 1000 \tTime : " + time_1000Elements_Singly);
            Console.WriteLine("Size : 10000 \tTime : " + time_10000Elements_Singly);
            Console.WriteLine("Size : 100000 \tTime : " + time_100000Elements_Singly);

            Console.ReadLine();

        }

        public static long timeSinglyLinkedList(long repetitions, long numberOfElements)
        {
            long timeElapsed = 0;

            Stopwatch timer = new Stopwatch();

            for (int r = 0; r < repetitions; r++)
            {
                SinglyLinkedList<int> sList = new SinglyLinkedList<int>();
             
                sList.InsertFirst(5);
                sList.InsertFirst(10);
                sList.InsertFirst(15);

                sList.InsertLast(0);
                sList.InsertLast(-5);
                sList.InsertLast(-10);

                timer.Start();

                for (int i = 0; i < numberOfElements; i++)
                {
                    sList.InsertBefore(5, sList.Head);
                }

                timer.Stop();
                timeElapsed = timeElapsed + timer.ElapsedTicks;
                timer.Reset();
            }
            long averageTime = timeElapsed / repetitions;

            return averageTime;
        }

        public static long timeDoublyLinkList(long repetitions, long numberOfElements)
        {
            long timeElapsed = 0;

            Stopwatch timer = new Stopwatch();

            for (int r = 0; r < repetitions; r++)
            {
                DoublyLinkedList<int> dList = new DoublyLinkedList<int>();

                dList.InsertFirst(5);
                dList.InsertFirst(10);
                dList.InsertFirst(15);

                dList.InsertLast(0);
                dList.InsertLast(-5);
                dList.InsertLast(-10);

                timer.Start();

                for (int i = 0; i < numberOfElements; i++)
                {
                    dList.InsertBefore(5, dList.Head);
                }

                timer.Stop();
                timeElapsed = timeElapsed + timer.ElapsedTicks;
                timer.Reset();
            }
            long averageTime = timeElapsed / repetitions;

            return averageTime;
        }
    }
}
