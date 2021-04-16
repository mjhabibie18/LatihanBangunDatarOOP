using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    abstract class BangunDatar
    {
        private double hitung;

        public double Menghitung
        {
            get { return hitung; }
            set { hitung = value; }
        }

        public abstract double hitungLuas();

        public abstract double hitungKeliling();
    }
}
