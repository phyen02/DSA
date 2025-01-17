/*
Nhập vào một số nguyên dương n, và n số nguyên lần lượt là các phần tử trong dãy a.
Hãy đưa ra một số nguyên là tổng tất cả các phần tử trong dãy đó.
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = 0;
            int[] arr = null;
            Console.WriteLine(Sum(n,arr));
        }

        public static int Sum(int n, int[] arr)
        {
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            int sum = 0;
            
            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                sum += arr[i];
            }
            return sum;
        }
    }
}