using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication02
{
    //TPL(Task Parallel Library)
    //PLINQ(Parallel Language INtegrated Query) 
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Enumerable.Range(1, 100000).ToArray();

            #region Parallel.For 

            Console.WriteLine("For\n");
            Parallel.For(1, numbers.Length,
                i =>
                {
                    if (i % 1500 == 0)
                        Console.Write("{0} ", i.ToString());
                }
            );

            Console.WriteLine("\n\nFor(İçeriden başka metod çağırarak)\n");

            Parallel.For(1, numbers.Length,
                (i) =>
                {
                    if (i % 1500 == 0)
                        Task1(i);
                }
            );


            #endregion

            #region Parallel.ForEach

            //Console.WriteLine("\n\nForEach Örneği\n");
            //Parallel.ForEach(numbers, number =>
            //{
            //    if (number % 1500 == 0)
            //        Console.Write("{0} ", number.ToString());
            //}
            //);

            #endregion

            #region Parallel.Invoke

            //    Console.WriteLine("\n\n");


            //    Parallel.Invoke(
            //        () =>
            //        {
            //            Console.WriteLine("Toplam Tek sayı hesabı başladı\n");
            //            Console.WriteLine("Thread ID {0} ", Thread.CurrentThread.ManagedThreadId.ToString());
            //            OddCount(numbers);
            //            Console.WriteLine("Toplam Tek sayı bulma işi tamamlandı\n");
            //        },
            //        () =>
            //        {
            //            Console.WriteLine("Toplam Çift sayı hesabı başladı\n");
            //            EvenCount(numbers);
            //            Console.WriteLine("Thread ID {0} ", Thread.CurrentThread.ManagedThreadId.ToString());
            //            Console.WriteLine("Toplam Çift sayı bulma işi tamamlandı\n");
            //        },
            //        () =>
            //        {
            //            Console.WriteLine("9 ile bölünenlerin toplamını bulma işi başladı\n");
            //            NineCount(numbers);
            //            Console.WriteLine("Thread ID {0} ", Thread.CurrentThread.ManagedThreadId.ToString());
            //            Console.WriteLine("9 ile bölünenlerin toplamını bulma işi tamamlandı\n");
            //        }
            //);

            #endregion
            Console.ReadLine();
        }

        static void Task1(int number)
        {
            Console.Write("{0} ", number.ToString());
        }

        static void EvenCount(int[] numbers)
        {
            int result = (from number in numbers
                          where number % 2 == 0
                          select number).Count();
            Console.WriteLine("\tDizi içerisinde {0} adet ÇİFT sayı vardır\n", result.ToString());
        }
        static void OddCount(int[] numbers)
        {
            int result = (from number in numbers
                          where number % 2 != 0
                          select number).Count();
            Console.WriteLine("\tDizi içerisinde {0} adet TEK sayı vardır\n", result.ToString());
        }

        static void NineCount(int[] numbers)
        {
            int result = (from number in numbers
                          where number % 9 == 0
                          select number).Count();
            Console.WriteLine("\tDizi içerisinde {0} adet 9 ile bölünebilen sayı vardır\n", result.ToString());
        }


    }
}
