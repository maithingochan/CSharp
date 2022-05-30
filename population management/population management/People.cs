using System;
using System.Collections.Generic;
using System.Text;

namespace population_management
{
    class People
    {
        private string hoTen;
        private Address diaChi;
        private string email;
        private static int  soNguoi = 0;
        private DateTime ngaySinh;

        // Contructors
        public  People(string hoTen, string _tenDuong, string _quan,string _thanhPho, DateTime ngaySinh) {
            this.hoTen = hoTen;
            this.diaChi = new Address(_tenDuong, _quan, _thanhPho);
            this.ngaySinh = ngaySinh;
            soNguoi++;
        }

        ~People() { }

        public string HoTen { get => hoTen; set => hoTen = value; }
        internal Address DiaChi { get => diaChi; set => diaChi = value; }
        public static int SoNguoi { get => soNguoi; set => soNguoi = value; }
    //    public DateTime NgaySinh { get => ngaySinh; set => ngaySinh = value; }

        public string toString()
        {
            return $"Ngay Thang Nam: {this.ngaySinh.Day}/{this.ngaySinh.Month}/{this.ngaySinh.Year}\n"+
                $"Ngươi: {this.hoTen} + {this.diaChi.toString()}";
        }

        public string createEmail()
        {
            string temEmail = this.hoTen.Replace(" ","");
            return temEmail+"@gmail.com";
        }
       


    }
}
