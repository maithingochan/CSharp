using System;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("nhập bài muốn kiểm tra");
            int n = int.Parse(Console.ReadLine());
            Program p = new Program();
            switch (n)
            {
                case 1:
                    int a06 = int.Parse(Console.ReadLine());
                    int b06 = int.Parse(Console.ReadLine());
                    p.tonghieutichthuong(a06, b06);
                    break;
                case 2:
                    Console.WriteLine("Hình ngôi sao");
                    p.ngoisao();
                    break;
                case 3:
                    Console.WriteLine("nhập số cần chuyển đổi");
                    int x06 = Convert.ToInt32(Console.ReadLine());
                    p.doisothapphanthanhnhiphan(x06);
                    break;
                case 4:
                    Console.WriteLine("Thông Tin Sinh Viên");
                    p.myinfo();
                    break;
            }    
        }
        void tonghieutichthuong(int a, int b)
        {
            Console.WriteLine("a + b = " + (a + b));
            Console.WriteLine("a - b = " + (a - b));
            Console.WriteLine("a * b = " + (a * b));
            Console.WriteLine("a / b = " + (a / b));
            Console.WriteLine("a % b = " + (a % b));
        }
        void doisothapphanthanhnhiphan(int n)
        {
            int j, bin=0;
            int i = 1;
            for (j = n; j > 0; j = j / 2)
            {
                bin = bin + (n % 2) * i;
                i = i * 10;
                n = n / 2;
            }

            Console.Write("\nSo trong he nhi phan tuong duong cua so {0} la {1}.\n\n", n, bin);

        }
        void myinfo()
        {
            String ten = "Đoàn Thanh Hà";
            String msv = "1911514110106";
            String lop = "19sk1";
            Console.WriteLine("Họ và tên   : {0}", ten);
            Console.WriteLine("Mã sinh viên: {0}", msv);
            Console.WriteLine("Lớp         : {0}", lop);

        }
        void ngoisao()
        {
            Console.WriteLine("=========================");
            Console.WriteLine("============*============");
            Console.WriteLine("===========***===========");
            Console.WriteLine("=======************=======");
            Console.WriteLine("==========*******========");
            Console.WriteLine("=========***===***========");
            Console.WriteLine("=========*=======*=======");
            Console.WriteLine("=========================");
        }
    }
}
