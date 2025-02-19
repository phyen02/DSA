/* Đề
Nhập vào một số nguyên dương `n`, và `n` số nguyên lần lượt là các phần tử trong dãy `a`. 

a. Nhập vào hai số nguyên là `k` và `x` (`0 ≤ k ≤ n`).
Hãy chèn phần tử có giá trị `x` vào dãy `a`, ở trước phần tử có chỉ số `k` và sau phần tử
có chỉ số `k-1`. In mảng kết quả ra màn hình, mỗi số cách nhau bởi một khoảng trắng.

b. Nhập vào số nguyên `k` (`0 ≤ k ≤ n`).
Hãy chèn phần tử có giá trị `k` vào cuổi mảng.
In mảng kết quả ra màn hình, mỗi số cách nhau bởi một khoảng trắng.

c. Nhập vào số nguyênk (0 ≤ k ≤ n).
Hãy chèn phần tử có giá trị k vào đầu mảng
n mảng kết quả ra màn hình, mỗi số cách nhau bởi một khoảng trắng.
*/
namespace Program
{
    class Program
    {
        public static void Main(string[] args)
        {
            int n, kb, ka, x, kc;
            int[] arr;

            do
            {
                Console.Write("Enter quantity for array (> 0): ");
                n = Convert.ToInt32(Console.ReadLine());
            } while (n < 1);
            arr = new int[n];
            ArrayInput(n, arr);
            ArrayOuput(n, arr);

            // a. Add x before arr[k] and after arr[k-1]
            Console.WriteLine("\n---------------");
            Console.WriteLine("Add value 'x' to 'k' position");
            Console.Write("Enter x: ");
            x = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter k: ");
            ka = Convert.ToInt32(Console.ReadLine());
            Console.Write(AddXToKPos(n, arr, ka, x));

            // b. Add k to end of array
            Console.WriteLine("\n---------------");
            Console.WriteLine("Add value to end array: ");
            Console.Write("Enter k: ");
            kb = Convert.ToInt32(Console.ReadLine());
            AddToEndArray(n, arr, kb);

            // c. Add k to begin of array
            Console.WriteLine("\n---------------");
            Console.WriteLine("Add value to begin array: ");
            Console.Write("Enter k: ");
            kc = Convert.ToInt32(Console.ReadLine());
            AddToBeginArray(n, arr, kc);
        }

        public static void ArrayInput(int n, int[] arr)
        {

            for (int i = 0; i < n; i++)
            {
                Console.Write("Enter arr[{0}]: ", i);
                arr[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        public static void ArrayOuput(int n, int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.Write("\n");
        }
        
        public static string AddXToKPos(int n, int[] arr, int k, int x)
        {
            Array.Resize(ref arr, n+1);
            for (int i = n; i >= k+1; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[k] = x;
            
            return string.Join(" ", arr);
        }

        public static void AddToEndArray(int n, int[] arr, int k)
        {
            Array.Resize(ref arr, n+1);
            arr[n] = k;
            ArrayOuput(n, arr);
        }
    
        public static void AddToBeginArray(int n, int[] arr, int k)
        {
            Array.Resize(ref arr, n+1);
            for(int i = n; i > 0; i--)
            {
                arr[i] = arr[i-1];
            }
            arr[0] = k;

            ArrayOuput(n, arr);
        }
    }
}