﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LatihanClassDanObject
{
    class Mahasiswa
    {
        public string Nim { get; set; }
        public string Nama { get; set; }
        public float Ipk { get; set; }

        public void Registrasi()
        {
            Console.WriteLine("Nim : {0}", Nim);
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("Ipk: {0}", Ipk);
            Console.WriteLine("Telah melakukan registrasi");
        }
        public void IsiKrs()
        {
            Console.WriteLine("{0} sedang melakukan proses Krs\n", Nama);
        }
    }
}