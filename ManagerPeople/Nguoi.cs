using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLyHoDanCu
{
    class Nguoi
    {
        string hoten;
        int tuoi;
        string nghenghiep;
        string cmnd;

        public Nguoi() { }

        public Nguoi(string hoten, int tuoi, string nghenghiep, string cmnd)
        {
            Hoten = hoten;
            Tuoi = tuoi;
            Nghenghiep = nghenghiep;
            Cmnd = cmnd;
        }

        public string Hoten { get => hoten; set => hoten = value; }
        public int Tuoi { get => tuoi; set => tuoi = value; }
        public string Nghenghiep { get => nghenghiep; set => nghenghiep = value; }
        public string Cmnd { get => cmnd; set => cmnd = value; }

        public void show()
        {
            Console.WriteLine("Hoten: " + hoten);
            Console.WriteLine("Tuoi: " + tuoi);
            Console.WriteLine("Nghe nghiep: " + nghenghiep);
            Console.WriteLine("CMND: " + cmnd);
            Console.WriteLine();
        }
    }
}
