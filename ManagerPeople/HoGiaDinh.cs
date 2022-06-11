using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class HoGiaDinh
    {
        int songuoi;
        List<Nguoi> thanhviens;
        string sonha;

        public HoGiaDinh() { }

        public HoGiaDinh(string sonha, List<Nguoi> thanhviens, int songuoi)
        {
            Sonha = sonha;
            Thanhviens = thanhviens;
            Songuoi = songuoi;
        }

        public string Sonha { get => sonha; set => sonha = value; }
        public List<Nguoi> Thanhviens { get => thanhviens; set => thanhviens = value; }
        public int Songuoi { get => songuoi; set => songuoi = value; }

        public void show()
        {
            int i = 1;
            foreach(Nguoi tv in thanhviens)
            {
                Console.WriteLine("Nguoi thu " + i);
                tv.show();
                Console.WriteLine();
                i++;
            }
        }
    }
}
