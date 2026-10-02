using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Comman
{
    public class Test
    {
        public static void DoSomeCode()
        {
            int x, y, z;
            Console.WriteLine("please enter first number");
            x = int.Parse(Console.ReadLine());

            Console.WriteLine("please enter second number");
            y = int.Parse(Console.ReadLine());

            z = x / y;

            Console.WriteLine($"result is : {z}");

            int[] arr = { 1, 2, 3, };
            Console.WriteLine("please enter index  number to change it's value");
            int index = int.Parse(Console.ReadLine());
            arr[index] = 10;
            Console.WriteLine(arr[index]);
        }
    }
}
