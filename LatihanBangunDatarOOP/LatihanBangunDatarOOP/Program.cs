using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanBangunDatarOOP
{
    class Program
    {
        public static void Main()
        {

            int pilih;
            int jml = 0;
            for (; ; )
            {
                string pilihan = "iya";

                if (jml != 0)
                {
                    Console.Write("Apakah ingin kembali ke menu awal? [iya/tidak]: ");
                    pilihan = Console.ReadLine();
                }
                if (pilihan.ToLower() == "tidak" && jml != 0)
                {
                    break;
                }
                else if (pilihan.ToLower() == "iya" && jml != 0 || jml == 0)
                {
                    Console.WriteLine("Masukan angka 1 - 5");
                    Console.WriteLine("1. Menghitung Luas dan Keliling Persegi");
                    Console.WriteLine("2. Menghitung Luas dan Keliling Persegi Panjang");
                    Console.WriteLine("3. Menghitung Luas dan Keliling Lingkaran");
                    Console.WriteLine("4. Menghitung Luas dan Keliling Segitiga");
                    Console.WriteLine("5. Menghitung Luas dan Keliling Jajar Genjang");
                    pilih = Convert.ToInt16(Console.ReadLine());

                    switch (pilih)
                    {
                        case 1:
                            try
                            {
                                persegi a = new persegi();
                                Console.Write("Masukan Nilai Sisi: ");
                                a.Sisi = double.Parse(Console.ReadLine());
                                Console.WriteLine("Luasnya adalah " + a.hitungLuas());
                                Console.WriteLine("Kelilingnya adalah " + a.hitungKeliling());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Harap masukan inputan berupa angka");
                            }
                            break;
                            

                        case 2:
                            try
                            {
                                persegiPanjang b = new persegiPanjang();
                                Console.Write("Masukan Nilai Panjang: ");
                                b.Panjang = double.Parse(Console.ReadLine());
                                Console.Write("Masukan Nilai Lebar: ");
                                b.Lebar = double.Parse(Console.ReadLine());
                                Console.WriteLine("Luasnya adalah " + b.hitungLuas());
                                Console.WriteLine("Kelilingnya adalah " + b.hitungKeliling());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Harap Masukan inputan berupa angka");
                            }
                            break;

                        case 3:
                            try
                            {
                                Lingkaran c = new Lingkaran();
                                Console.Write("Masukan Nilai Jari-Jari: ");
                                c.JariJari = double.Parse(Console.ReadLine());
                                Console.WriteLine("Luasnya adalah " + c.hitungLuas());
                                Console.WriteLine("Kelilingnya adalah " + c.hitungKeliling());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Harap Masukan inputan berupa angka");
                            }
                            break;

                        case 4:
                            try
                            {
                                Segitiga d = new Segitiga();
                                Console.Write("Masukan Nilai Alas: ");
                                d.Alas = double.Parse(Console.ReadLine());
                                Console.Write("Masukan Nilai Tinggi: ");
                                d.Tinggi = double.Parse(Console.ReadLine());
                                Console.Write("Masukan Nilai Sisi: ");
                                d.Sisi = double.Parse(Console.ReadLine());
                                Console.WriteLine("Luasnya adalah " + d.hitungLuas());
                                Console.WriteLine("Kelilingnya adalah " + d.hitungKeliling());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Harap Masukan inputan berupa angka");
                            }
                            break;

                        case 5:
                            try
                            {
                                JajarGenjang e = new JajarGenjang();
                                Console.Write("Masukan Nilai Alas: ");
                                e.Alas = double.Parse(Console.ReadLine());
                                Console.Write("Masukan Nilai Tinggi: ");
                                e.Tinggi = double.Parse(Console.ReadLine());
                                Console.Write("Masukan Nilai Sisi Miring: ");
                                e.SisiMiring = double.Parse(Console.ReadLine());
                                Console.WriteLine("Luasnya adalah " + e.hitungLuas());
                                Console.WriteLine("Kelilingnya adalah " + e.hitungKeliling());
                            }
                            catch (FormatException)
                            {
                                Console.WriteLine("Harap masukan inputan berupa angka");
                            }
                            break;

                        default:
                            Console.WriteLine("Tolong masukan nilai 1 - 5 ");
                            Console.ReadLine();
                            break;
                    }
                    jml++;
                }
            }
        }
    }
}
