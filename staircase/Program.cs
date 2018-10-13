
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace staircase
{
    class Program
    {
        private static void staircase(int n)
        {
            for (int i = 1; i <= n; i++)
            {
                Console.WriteLine(new String(' ', n - i) + new String('#', i));
            }
        }
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            staircase(n);
            Console.ReadLine();
        }
    }
}
