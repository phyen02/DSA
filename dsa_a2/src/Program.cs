/*
Nhập vào một số nguyên dương n, và n số nguyên lần lượt là các phần tử trong dãy a.

Hãy thay đổi giá trị của mỗi phần tử thành bình phương của chính nó, sau đó in mảng
đó ra màn hình (mỗi phần tử cách nhau bởi một khoảng trắng).
*/

using System;

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[n];

            for (int i = 0; i < n; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0; i < n; i++)
            {
                arr[i] = arr[i]*arr[i];
            }

            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
        }
    }
}