using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class KhuPho
    {
        public List<HoGiaDinh> khuphos;

        public KhuPho(List<HoGiaDinh> khupho)
        {
            Khupho = khupho;
        }

        public List<HoGiaDinh> Khupho { get => khuphos; set => khuphos = value; }

        public void themThanhVien(HoGiaDinh hgd)
        {
            Console.Write("Ho ten: ");
            string ht = Console.ReadLine();
            Console.Write("Tuoi: ");
            int tuoi = int.Parse(Console.ReadLine());
            Console.Write("Nghe nghiep: ");
            string nn = Console.ReadLine();
            Console.Write("CMND: ");
            string cmnd = Console.ReadLine();

            Nguoi tv = new Nguoi(ht, tuoi, nn, cmnd);
            hgd.Thanhviens.Add(tv);
        }

        public void themHoGiaDinh(int n, string sonha)
        {
            List<Nguoi> tvs = new List<Nguoi> { };
            HoGiaDinh hgd = new HoGiaDinh(sonha, tvs, n);

            for(int i=1; i<=n; i++)
            {
                Console.WriteLine("Thanh vien thu " + 1);
                themThanhVien(hgd);
            }

            Khupho.Add(hgd);
        }

        public void hienthi()
        {
            int i = 1;
            foreach(HoGiaDinh hgd in khuphos)
            {
                Console.WriteLine("Ho gia dinh thu " + i);
                hgd.show();
                i++;
            }
        }
    }
}
