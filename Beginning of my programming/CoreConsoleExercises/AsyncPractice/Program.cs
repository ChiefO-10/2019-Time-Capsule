using System;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncPractice
{
    class Program
    {
        static async Task Main(string[] args)
        {
            Console.WriteLine("Starting");
            asyn();
            while (true)
            {

            }
        }

        static async void asyn()
        {
            Method1Async();
            while (true)
            {
                MethodAsync2();
            }
        }

        static async Task Method1Async()
        {
            while (true)
            {
                //Thread.Sleep(2000);  BLOCKS
                await Task.Delay(2000);
                Console.WriteLine("x");
            }
        }

        static async Task MethodAsync2()
        {
            var result = new List<int>();

            for (int i = 0; i < 10; i++)
            {
                await Task.Delay(2000);
                //Thread.Sleep(5000);
                int a = await AddingIntAsync(i);
                Console.WriteLine(a);
            }
        }
        
        static async Task<int> AddingIntAsync(int a)
        {
            for (int i = 0; i < 2000; i++)
            {
                a += i;
            }
            return a;
        }
    }
}
