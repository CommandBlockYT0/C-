using System;
using System.Threading.Tasks;

namespace Task01
{
    class Box
    {
        int num;
        public int Num { get { return Num; } }
        public Box(int num) => this.num = num;
    }
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
