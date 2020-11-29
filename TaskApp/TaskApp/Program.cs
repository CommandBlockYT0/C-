using System;
using System.Threading.Tasks;

namespace Task01
{
    class Program
    {
        static void Main(string[] args)
        {
            Task<int> task = new Task<int>(delegate ()
            {
                int sum = 0;
                for (int i = 1; i <= 100; i++)
                {
                    sum += i;
                }
                return sum;
            });
            task.Start();
            Console.WriteLine(task.Result);

        }
    }
}
