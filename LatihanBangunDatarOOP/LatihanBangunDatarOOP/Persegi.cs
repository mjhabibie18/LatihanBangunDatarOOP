using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    class persegi : BangunDatar
    {
        private double NilaiSisi;

        public double Sisi
        {
            get { return NilaiSisi; }
            set { NilaiSisi = value; }
        }
        public override double hitungLuas()
        {
            hitung = NilaiSisi * NilaiSisi;
            return hitung;
        }
        public override double hitungKeliling()
        {
            hitung = NilaiSisi * 4;
            return hitung;
        }
    }
}
