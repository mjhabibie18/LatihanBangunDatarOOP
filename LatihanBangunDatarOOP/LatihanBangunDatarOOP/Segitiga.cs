using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    class Segitiga : BangunDatar
    {
        private double NilaiAlas;
        private double NilaiSisi;
        private double NilaiTinggi;

        public double Alas
        {
            get { return NilaiAlas; }
            set { NilaiAlas = value; }
        }
        public double Sisi
        {
            get { return NilaiSisi; }
            set { NilaiSisi = value; }
        }
        public double Tinggi
        {
            get { return NilaiTinggi; }
            set { NilaiTinggi = value; }
        }
        public override double hitungLuas()
        {
            hitung = (NilaiAlas * NilaiTinggi) / 2;
            return hitung;
        }
        public override double hitungKeliling()
        {
            hitung = NilaiAlas + NilaiTinggi + NilaiSisi;
            return hitung;
        }
    }
}
