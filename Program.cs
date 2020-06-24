using System;
using Collection.induk;
using Collection.anak;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Tugas Lab 	PEMROGRAMAN (Pertemuan 11) -- Polymorphism, Abstraction & Collection ";

        
            KaryawanTetap karyawantetap = new KaryawanTetap();
            karyawantetap.Nik = "123-234-345";
            karyawantetap.Nama = "Sastro Jemiran";
            karyawantetap.GajiBulanan = 3500000;

            KaryawanHarian karyawanharian = new KaryawanHarian();
            karyawanharian.Nik = "234-123-333";
            karyawanharian.Nama = "Tumiren";
            karyawanharian.JumlahJamKerja = 8;
            karyawanharian.UpahPerJam = 10000;

            Sales sales = new Sales();
            sales.Nik = "100-111-368";
            sales.Nama = "Sasminto";
            sales.JumlahPenjualan = 30;
            sales.Komisi = 45000;
            // objek class collection
            List<Karyawan> listkaryawan = new List<Karyawan>();

            listkaryawan.Add(karyawantetap);
            listkaryawan.Add(karyawanharian);
            listkaryawan.Add(sales);

            int noUrut = 1;

            foreach (Karyawan karyawan in listkaryawan)
            {
                Console.WriteLine("{0}. Nik: {1} Nama: {2} Gaji: {3:N0}",
                    noUrut,
                    karyawan.Nik,
                    karyawan.Nama,
                    karyawan.TotalGaji());

                noUrut++;
            }
            

            Console.ReadKey();
        }
    }
}

