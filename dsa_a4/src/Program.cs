/*
Nhập vào một số nguyên dương `n`, và `n` số nguyên lần lượt là các phần tử trong dãy `a`.
Tiếp theo nhập vào hai số nguyên là `k` (`0 ≤ k ≤ n`).
    a. Xoá phần tử ở vị trí thứ 'k' trong dãy a.
    b. Hãy xoá phần tử có giá trị `k` trong dãy `a`.
    c. Xoá phần tử đầu tiên trong dãy `a`.
    d. Xoá phần tử cuối cùng trong dãy `a`.
In mảng các kết quả ra màn hình, mỗi số cách nhau bởi một khoảng trắng.
*/

namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n;
            int[] arr;

            Console.Write("Enter quantity for array: ");
            n = Convert.ToInt32(Console.ReadLine());
            arr = new int[n];
            InputArray(arr, n);
            OutputArray(arr, n);

            // a. Delete value at position 'k' in array
            // int ka;
            // Console.WriteLine("---------------");
            // Console.Write("Input value position to remove: ");
            // ka = Convert.ToInt32(Console.ReadLine());
            // RemoveValueAt(arr, ref n, ka);
            // OutputArray(arr,n);

            // b. Delete value 'k' in array
            int kb;
            Console.WriteLine("---------------");
            Console.Write("Input value to remove: ");
            kb = Convert.ToInt32(Console.ReadLine());
            RemoveValue(arr, ref n, kb);
            OutputArray(arr, n);
        }

        public static void InputArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write("arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void OutputArray(int[] arr, int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
    
        public static void RemoveValueAt(int[] arr, ref int n, int k)
        {
            for (int i = k; i < n-1; i++)
            {
                arr[i] = arr[i+1];
            }
            n--;
        }

        public static void RemoveValue(int[] arr, ref int n, int k)
        {
            for (int i = 0; i < n; i++)
            {
                if (arr[i] == arr[k])
                {
                    RemoveValueAt(arr, ref n, k);
                }
            }
            n--;
        }
    }
}