using System;
using System.Collections.Generic;
using System.Text;

namespace population_management
{
    class Address
    {
        private string _tenDuong;
        private string _quan;
        private string _thanhPho;

      

        public Address(string _tenDuong, string _quan, string _thanhPho)
        {
            this._tenDuong = _tenDuong;
            this._quan = _quan;
            this._thanhPho = _thanhPho;
        }

        ~Address() { }

        public string TenDuong { get => _tenDuong; set => _tenDuong = value; }
        public string Quan { get => _quan; set => _quan = value; }
        public string ThanhPho { get => _thanhPho; set => _thanhPho = value; }

        public string   toString()
        {
            return $"Dia Chi: {this._tenDuong}, {this._quan}, {this._thanhPho}\n";
        }
        public static bool operator ==(Address Ad1, Address Ad2)
        {
            return Ad1.TenDuong.Equals(Ad2.TenDuong) && Ad1.Quan.Equals(Ad2.Quan) && Ad1.ThanhPho.Equals(Ad2.ThanhPho);
        }
        public static bool operator != (Address Ad1, Address Ad2)
        {
            return !(Ad1==Ad2);
        }
    }
}
