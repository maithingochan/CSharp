using System;
using System.Text;

namespace BT10_05
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] arr_06 = new int[10];
            int n = 10;
            Nhapso(out arr_06);
            xuat(arr_06);
            sapxep(arr_06);
            xuat(arr_06);
            Console.WriteLine("số max {0} ", munMax(arr_06));
            Console.WriteLine("số min {0} ", munMin(arr_06));
            sepnguoc(arr_06);

        }

        private static void Nhapso(out int[] arr)
        {
            Console.WriteLine("nhập 10 phần tử bất kỳ");
           
            for (int i =0;i< 10; i++)
            {
                arr[i] = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("số thư {0} : {1} ", i, arr[i]);
            }
        }
        static void xuat(int[] arr_06)
        {
            Console.WriteLine("giá trị của 10 phần tử bất kỳ");
            for (int i = 0; i < arr_06.Length; i++)
            {

                Console.Write("\t{0} ", arr_06[i]);
            }
        }
        private static int munMax(int[] arr)
        {
            int max = int.MinValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] > max)
                {
                    int tg = arr[i];
                    arr[i] = max;
                    max = tg;
                }
            }
            return max;
        }

        private static int munMin(int[] arr)
        {
            int min = int.MaxValue;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] < min)
                {
                    int tg = arr[i];
                    arr[i] = min;
                    min = tg;
                }
            }
            return min;
        }
        static void sepnguoc(int[] arr)
        {
            int i = 0, j = 0;
            while (i < j)
            {
                int temp = arr[i];
                arr[i] = arr[j];
                arr[j] = temp;
                i++;
                j--;
            }
        }
        static void sapxep(int[] arr_06)
        {
            for (int i = 0; i < arr_06.Length; i++)
            {
                for (int j = i + 1; j < arr_06.Length; j++)
                {
                    if (arr_06[j] < arr_06[i])
                    {
                        //cach trao doi gia tri
                        int tmp = arr_06[i];
                        arr_06[i] = arr_06[j];
                        arr_06[j] = tmp;
                    }
                }
            }
        }
    }
}
