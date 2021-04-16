using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    class JajarGenjang : BangunDatar
    {
        private double NilaiAlas;
        private double NilaiTinggi;
        private double NilaiSisiMiring;

        public double Alas
        {
            get { return NilaiAlas; }
            set { NilaiAlas = value; }
        }

        public double Tinggi
        {
            get { return NilaiTinggi; }
            set { NilaiTinggi = value; }
        }
        public double SisiMiring
        {
            get { return NilaiSisiMiring; }
            set { NilaiSisiMiring = value; }
        }
        public override double hitungLuas()
        {
            Menghitung = NilaiAlas * NilaiTinggi;
            return Menghitung;
        }
        public override double hitungKeliling()
        {
            Menghitung = 2 * (NilaiAlas + NilaiSisiMiring);
            return Menghitung;
        }
    }
}
