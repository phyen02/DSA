/*
Nhập vào một số nguyên dương `n`, và `n` số nguyên lần lượt là các phần tử trong dãy `a`.
Tiếp theo nhập vào hai số nguyên là `k` và `x` (`0 ≤ k ≤ n`).

Hãy chèn phần tử có giá trị `x` vào dãy `a`, ở trước phần tử có chỉ số `k` và sau phần tử có chỉ số `k-1`.
In mảng kết quả ra màn hình, mỗi số cách nhau bởi một khoảng trắng.
*/

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

            uint k = Convert.ToUInt32(Console.ReadLine());
            uint x = Convert.ToUInt32(Console.ReadLine());
        }
    }
}