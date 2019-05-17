using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ConsoleApplication04
{
    class Program
    {
        #region 001
        //static void Main()
        //{

        //    AsyncMethodIslem();

        //    Console.ReadKey();
        //}

        //private static async void AsyncMethodIslem()
        //{
        //    await async method çağırılırken kullanıyor.Diğer threadimiz yoluna devam eder
        //    string result = await Islem();

        //    DoAsync() metodu tamamlanmadan bu satır yürütülmez.
        //   Console.WriteLine(result);
        //}

        //static Task<string> Islem()
        //{
        //    return Task.Run<string>(() =>
        //    {
        //        return "hede";
        //    });
        //}
        #endregion
        #region 002
        //static void Main()
        //{
        //   // CallIDGetirAsync();
        //     CallContinueIDGetirAsync();
        //    Console.WriteLine("Çalıştı");
        //    var a = 10 + 4;
        //    Console.WriteLine(a);
        //    Thread.Sleep(500);
        //    Console.WriteLine("Çalıştı");
        //    Console.ReadKey();
        //}

        //private static async void CallIDGetirAsync()
        //{
        //    string result = await IDGetirAsync("4545");
        //    Console.WriteLine(result);
        //}

        //private static void CallContinueIDGetirAsync()
        //{
        //    Task<string> t1 = IDGetirAsync("99999");
        //    t1.ContinueWith(t =>
        //    {
        //        string result = t.Result;

        //        Console.WriteLine(result);
        //    });
        //}
        //static string IDGetir(string id)
        //{
        //    Thread.Sleep(1000);
        //    return $"ID, {id}";

        //}
        //static Task<string> IDGetirAsync(string id)
        //{

        //    return Task.Run<string>(() =>
        //    {
        //        return IDGetir(id);
        //    });
        //}
        #endregion
    }
}
