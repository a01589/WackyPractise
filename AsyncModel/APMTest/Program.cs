using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;

namespace APMTest
{
    class Program
    {
        public delegate void PrintDelegate();

        static void Main(string[] args)
        {
            Async();
            Console.WriteLine("主线程执行完成");
            Console.Read();
        }

        private static void Async()
        {
            PrintDelegate del = new PrintDelegate(Print);
            IAsyncResult ar = del.BeginInvoke(new AsyncCallback(CallBack), null);
        }

        private static void Print()
        {
            Thread.Sleep(5000);
            Console.WriteLine("执行完成！");
        }

        private static void CallBack(IAsyncResult ar)
        {
            while (true) 
            {
                if (ar.IsCompleted) 
                {
                    Console.WriteLine("执行完成回调");
                    break;
                }
            }
            Console.WriteLine("回调完成");
        }

    }
}
