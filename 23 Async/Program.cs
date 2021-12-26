using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _23_Async
{
    class Program
    {
        static int Fact (int a)
        {
            int f = 1;
            for (int i = 1; i < a+1; i++)
            {
                f *= i;
            }
            return f;
        }
        static void Main(string[] args)
        {
            int a = Convert.ToInt32(Console.ReadLine());
            int r = FactAsync(a).Result;
            Console.WriteLine(r);
            Console.ReadKey();
        }
        static async Task<int> FactAsync(int a)
        {
            int result = await Task.Run<int>(() => Fact(a));
            return result;
        }
    }
}
