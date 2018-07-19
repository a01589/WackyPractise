using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace TPLTest
{
    class Program
    {

        static void Main(string[] args)
        {
            CancellationTokenSource cts = new CancellationTokenSource();
            Task<int> task = new Task<int>(() => Add(cts.Token), cts.Token);
            task.Start();
            task.ContinueWith(TaskEnded);
            Console.ReadKey();
            cts.Cancel();
            Console.WriteLine(task.Result);
            Console.ReadKey();
        }

        static void TaskEnded(Task<int> task)
        {
            Console.WriteLine("任务完成，完成时候的状态为：");
            Console.WriteLine("IsCanceled={0}\tIsCompleted={1}\tIsFaulted={2}", task.IsCanceled, task.IsCompleted, task.IsFaulted);
            Console.WriteLine("任务的返回值为：{0}", task.Result);
        }

        static int Add(CancellationToken ct)
        {
            Console.WriteLine("任务开始...");
            int result = 0;
            try
            {
                while (true)
                {
                    ct.ThrowIfCancellationRequested();
                    result++;
                    Thread.Sleep(1000);
                }
            }
            catch (OperationCanceledException ex)
            {

            }
            return result;
        }
    }
}
