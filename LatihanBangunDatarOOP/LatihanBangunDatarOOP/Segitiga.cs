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
            Menghitung = (NilaiAlas * NilaiTinggi) / 2;
            return Menghitung;
        }
        public override double hitungKeliling()
        {
            Menghitung = NilaiAlas + NilaiTinggi + NilaiSisi;
            return Menghitung;
        }
    }
}
