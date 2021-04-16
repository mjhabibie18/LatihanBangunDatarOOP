using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
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
}
