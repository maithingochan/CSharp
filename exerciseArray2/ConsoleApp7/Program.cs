using System;
using System.Text;
namespace ConsoleApp7
{
    class Program
    {
        static void Main()
        {
            Boolean kt = false;
            Console.OutputEncoding = Encoding.Unicode;
            Console.InputEncoding = Encoding.Unicode;
            int[] Array;
            int spt;
            while(true)
            {
                Console.Clear();
                
                Console.WriteLine();
                Console.WriteLine("bài tập tập ");
                Console.WriteLine("bài tập 58 bấm 58");
                Console.WriteLine("bài tập 59 bấm 59");
                Console.WriteLine("bài tập 61 bấm 61");
                Console.WriteLine("bài tập 63 bấm 63");
                Console.WriteLine("bài tập 64 bấm 64");
                Console.WriteLine("bài tập 65 bấm 65");
                Console.WriteLine("bài tập 66 bấm 66");
                int n = Convert.ToInt32(Console.ReadLine());
                switch (n)
                {
                    case 61:
                        kt = true;
                        int[] arr;
                        nhapchan:
                            Console.WriteLine("Nhap so phan tu mang");
                            dynamic v = Convert.ToInt32(Console.ReadLine());
                       if(v % 2 != 0)
                            goto nhapchan;
                        SinhMang(out arr, v);
                        HienMang(arr);
                        Console.WriteLine("tong số nguyên dương {0}", Tong(arr));
                        int x = Convert.ToInt32(Console.ReadLine());
                        Xoa(arr, x);
                        HienMang(arr);
                        Console.WriteLine("Số lơn nhất  {0}", NMax(arr));
                        break;
                    case 59:
                        kt = true;
                        Console.WriteLine("nhập vào số năm cần kiểm tra");
                        int year = Convert.ToInt32(Console.ReadLine());
                        LichCanChi(year);
                        break;
                    case 58:
                        kt = true;
                        Console.WriteLine("nhập vào n số cần kiểm tra");
                        int snt = Convert.ToInt32(Console.ReadLine());
                        Eratosthenes(snt);
                        break;
                    case 63:
                        kt = true;
                        Console.WriteLine("nhập vào n số cần kiểm tra");
                        spt = Convert.ToInt32(Console.ReadLine());
                        SinhMang(out Array, spt);
                        HienMang(Array);
                        Console.WriteLine(" có {0} phần tử chia hêt cho 4 và tận cùng là 6",DivisibleBy4AndEndWith6(Array));
                        Console.WriteLine("phần tử lẻ sau khi nhân 2");
                        X2ElementOdd(Array);
                        HienMang(Array);
                        break;
                    case 64:
                        kt = true;
                        Console.WriteLine("nhập vào n số cần kiểm tra");
                        spt = Convert.ToInt32(Console.ReadLine());
                        createArrayOnedirection(spt,out Array);
                        HienMang(Array);
                        Console.WriteLine("số phần tử là lũy thừa của 2 là {0}", isPowerOfTwokt(Array));
                        Console.WriteLine("nhập vào n số cần xóa");
                        int del = Convert.ToInt32(Console.ReadLine());
                        int dem = deleteArray(Array, del);
                        HienMang1(Array, dem);
                        break;
                    case 65:
                        kt = true;
                        Console.WriteLine("nhập vào n số cần kiểm tra");
                        spt = Convert.ToInt32(Console.ReadLine());
                        createArrayOnedirection(spt, out Array);
                        HienMang(Array);
                        Console.WriteLine("trung bình số nguyên âm {0}", calculateOddNegativeIntegers(Array));
                        break;
                    case 66:
                        kt = true;
                        Console.WriteLine("nhập vào n số cần kiểm tra");
                        spt = Convert.ToInt32(Console.ReadLine());
                        SinhMang(out Array, spt);
                        HienMang(Array);
                        Console.WriteLine("số max {0} ", munMax(Array));
                        Console.WriteLine("số min {0} ", munMin(Array));
                        break;
                    case 0:
                        Console.WriteLine("\nBan da chon thoat chuong trinh!");
                        return;
                    default:
                        Console.WriteLine("bài tập tập này vẫn đang tiếp tục làm");
                        Console.WriteLine("bấm 1 phím để tiếp tục");
                        break;
                }
                Console.ReadKey();
            }
        }

        
        

        private static void SinhMang(out int[] arr, int n)
        {
            if (n > 0 && n % 2 == 0)
            {
                arr = new int[n];
                Random rand = new Random();
                int i = 0;
                while (i < n)
                {
                    int x = rand.Next(-100,100);
                    arr[i] = x;
                    i++;
                }
            }else
            {
                arr = null;
            }
        }


        private static int Tong(int [] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > 0)
                {
                    sum += arr[i];
                }
            }
            return sum;

        }
        //Bài 58
        private static void Eratosthenes(int n)
        {
            Boolean[] check = new Boolean[n+1];

            for(int i = 0; i <= n; i++)
            {
                check[i] = true;
            }

            for(int i = 2;i< n; i++)
            {
                if(check[i] == true)
                {
                    for(int j = 2 * i; j <= n; j+=i)
                    {
                        check[j] = false;
                    }
                    
                }
            }

            for (int i = 2; i <= n; i++)
            {
                if (check[i] == true)
                {
                    Console.Write("{0}\t", i);
                }
            }
        }

        //Bài 59
        private static void LichCanChi(int year)
        {
            String[] can = {"Canh", "Tan", "Nham", "Quy", "Giap","At", "Binh", "Dinh", "Mau", "Ky"};
            String[] chi = {"Than", "Dau", "Tuat", "Hoi", "Ti", "Suu","Dan", "Meo", "Thin", "Ty", "Ngo", "Mui"};

            Console.WriteLine("Năm {0} có năm âm lịch là: {1} {2}", year, can[year % 10], chi[year % 12]);
           
        }

        

        private static int Xoa(int[] arr, int x)
        {
            int k = 0;
             for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != x)
                {
                    arr[k] = arr[i];
                    k++;
                } 
            }
            return k;
        }

        private static int NMax(int[] arr)
        {
            int max = arr[0];
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] > max)
                {
                    max = arr[i];
                }
            }
            return max;
        }
        private static void HienMang(int[] arr)
        {
            for(int i= 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }

        // Bài 63
        private static int DivisibleBy4AndEndWith6(int[] arr)
        {
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 4 == 0 && Math.Abs(arr[i]) % 10 == 6)
                {
                    dem++;
                }
            }
            return dem;
        }

        private static void X2ElementOdd(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                if(arr[i] % 2 != 0)
                {
                    arr[i] *= 2;
                } 
            }
        }
        // Bài 64
        private static void createArrayOnedirection(int n ,out int[] array)
        {
            array = new int[n];

            for(int i = 0; i < n; i++)
            {
                Console.Write("a[{0}] = ",(i+1));
                array[i] = Convert.ToInt32(Console.ReadLine());
            }
        }

        private static int isPowerOfTwokt(int[] array)
        {
            int dem = 0;
            for(int i = 0; i< array.Length; i++)
            {
                if (isPowerOfTwo(array[i]))
                {
                    dem++;
                }
            }
            return dem;
        }

        private static bool isPowerOfTwo(int n)
        {
            if (n == 0 || n == 1)
                return true;
            int x = n / 2;
            int y = n % 2;
            if (y == 1)
                return false;
            return isPowerOfTwo(x);
        }

        private static int deleteArray(int[] arr,int n)
        {
            int k = 0;
            int dem = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] != n)
                {
                    arr[k] = arr[i];
                    k++;
                    dem++;
                }
            }
            return dem;
        }

        private static void HienMang1(int[] arr,int n)
        {
            for (int i = 0; i < n; i++)
            {
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();
        }
        // Bài 65
        private static float calculateOddNegativeIntegers(int[] arr)
        {
            int sum = 0;
            float medium=0;
            int dem = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i] < 0)
                {
                    sum += arr[i];
                    dem++;
                }
            }
            medium = (float)sum / dem;
            return medium;
        }

        private static int deleteArray1(int[] arr, int n)
        {
            int k = 0;
            int dem = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != n)
                {
                    arr[k] = arr[i];
                    k++;
                    dem++;
                }
            }
            return dem;
        }

        private static int munMax(int[] arr)
        {
            int max = int.MinValue;
            for(int i = 0; i < arr.Length; i++)
            {
                if(arr[i]> max)
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
    }
}
