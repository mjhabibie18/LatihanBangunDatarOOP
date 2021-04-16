using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    abstract class BangunDatar
    {
        public double hitung;

        public double Menghitung
        {
            get { return hitung; }
            set { hitung = value; }
        }
        public abstract double hitungLuas();
        public abstract double hitungKeliling();
    }

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

    class Lingkaran : BangunDatar
    {
        private double r;

        public double JariJari
        {
            get { return r; }
            set { r = value; }
        }
        public override double hitungLuas()
        {
            hitung = 3.14 * r * r;
            return hitung;
        }
        public override double hitungKeliling()
        {
            hitung = 2 * 3.14 * r;
            return hitung;
        }
    }

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
            hitung = NilaiAlas * NilaiTinggi / 2;
            return hitung;
        }
        public override double hitungKeliling()
        {
            hitung = NilaiAlas + NilaiTinggi + NilaiSisi;
            return hitung;
        }
    }
    class Program
    {

    }
}
