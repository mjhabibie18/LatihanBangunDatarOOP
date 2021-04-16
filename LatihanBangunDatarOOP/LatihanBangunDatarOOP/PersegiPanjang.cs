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
            hitung = NilaiPanjang * NilaiLebar;
            return hitung;
        }
        public override double hitungKeliling()
        {
            hitung = (NilaiPanjang + NilaiLebar) * 2;
            return hitung;
        }
    }
}
