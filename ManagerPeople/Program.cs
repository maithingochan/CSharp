using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class Program
    {
        static void Main(string[] args)
        {
            List<HoGiaDinh> hgd = new List<HoGiaDinh> { };
            KhuPho khuPho = new KhuPho(hgd);

            Console.Write("Nhap so ho gia dinh: ");
            int n = int.Parse(Console.ReadLine());

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Ho gia dinh thu " + i);
                Console.Write("Nhap so nha: ");
                string sonha = Console.ReadLine();
                Console.Write("Nhap so thanh vien: ");
                int sl = int.Parse(Console.ReadLine());
                khuPho.themHoGiaDinh(sl, sonha);
            }

            Console.WriteLine("===============");
            khuPho.hienthi();

            Console.ReadLine();
        }
    }
}
