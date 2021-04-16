using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    class persegiPanjang : BangunDatar
    {
        private double NilaiPanjang;
        private double NilaiLebar;

        public double Panjang
        {
            get { return NilaiPanjang; }
            set { NilaiPanjang = value; }
        }
        public double Lebar
        {
            get { return NilaiLebar; }
            set { NilaiLebar = value; }
        }
        public override double hitungLuas()
        {
            Menghitung = NilaiPanjang * NilaiLebar;
            return Menghitung;
        }
        public override double hitungKeliling()
        {
            Menghitung = (NilaiPanjang + NilaiLebar) * 2;
            return Menghitung;
        }
    }
}
