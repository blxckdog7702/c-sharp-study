using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication1.chap4
{
    public class Util
    {
        public static void PrintByteArr(byte[] arr)
        {
            foreach (byte input in arr)
            {
                Console.WriteLine("{0:X}", input);
            }
        }

        public static void PrintObjectArr(object[] arr)
        {
            foreach (object input in arr)
            {
                Console.WriteLine("{0}", input.ToString());
            }
        }

        public static void PrintIntArr(int[] arr)
        {
            foreach (int input in arr)
            {
                Console.WriteLine("{0}", input);
            }
        }

        public static bool IsPrime(int candidate)
        {
            int i;

            if((candidate & 1) == 0)
            {
                return candidate == 2;
            }

            for (i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0) return false;
            }

            return candidate != 1;
        }

        public static long Cumsum(int start, int end)
        {
            long sum = 0;

            for (int i = start; i <= end; i++)
            {
                sum += i;
            }

            return sum;
        }
    }
}
