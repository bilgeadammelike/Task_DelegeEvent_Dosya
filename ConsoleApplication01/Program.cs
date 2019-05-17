using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication01
{
    class Program
    {
        #region 001
        static void Main(string[] args)
        {
            ThreadStart testThreadStart = new ThreadStart(new Program().testThread);
            Thread testThread = new Thread(testThreadStart);

            testThread.Start();
            Console.ReadLine();
        }

        public void testThread()
        {
            int count = 0;
            while (count++ < 5)
            {
                Console.WriteLine("Thread  " + count);
                Thread.Sleep(500);
            }
        }
        #endregion

        #region 002
        //static void Main(string[] args)
        //{
        //    ThreadStart testThread1Start = new ThreadStart(new Program().testThread1);
        //    ThreadStart testThread2Start = new ThreadStart(new Program().testThread2);

        //    Thread[] testThread = new Thread[2];
        //    testThread[0] = new Thread(testThread1Start);
        //    testThread[1] = new Thread(testThread2Start);

        //    foreach (Thread myThread in testThread)
        //    {
        //        myThread.Start();
        //    }

        //    Console.ReadLine();
        //}

        //public void testThread1()
        //{
        //    int count = 0;
        //    while (count++ < 10)
        //    {
        //        Console.WriteLine(count + " Thread 1 çalıştı..");
        //        Thread.Sleep(1);
        //    }
        //}

        //public void testThread2()
        //{
        //    int count = 0;
        //    while (count++ < 10)
        //    {
        //        Console.WriteLine(count + "  Thread 2 çalıştı..");
        //        Thread.Sleep(1);
        //    }
        //}
        #endregion

        #region 003
        //static void Main(string[] args)
        //{
        //    ThreadPool.QueueUserWorkItem(new Program().testThread1);
        //    ThreadPool.QueueUserWorkItem(new Program().testThread2);
        //    Console.ReadLine();
        //}

        //public void testThread1(Object threadContext)
        //{
        //    //executing in thread
        //    int count = 0;
        //    while (count++ < 10)
        //    {
        //        Console.WriteLine(count + " Thread 1 çalıştı..");
        //        Thread.Sleep(100);
        //    }
        //}

        //public void testThread2(Object threadContext)
        //{
        //    //executing in thread
        //    int count = 0;
        //    while (count++ < 10)
        //    {
        //        Console.WriteLine(count + " Thread 2 çalıştı..");
        //        Thread.Sleep(100);
        //    }
        //}
        #endregion
    }
}
