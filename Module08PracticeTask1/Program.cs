using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module08PracticeTask1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            RangeOfArray arr = new RangeOfArray(6, 10);
            arr[6] = 42;
            arr[7] = 15;

            for (int i = 6; i <= 10; i++)
            {
                Console.WriteLine($"arr[{i}] = {arr[i]}");
            }
        }
    }
}
