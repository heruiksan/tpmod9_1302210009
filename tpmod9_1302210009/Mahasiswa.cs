﻿namespace tpmod9_1302210009
{
    public class Mahasiswa
    {
        public string Nama { get; set; }
        public string Nim { get; set; }

        public Mahasiswa() { }
        public Mahasiswa(string Nama, string Nim)
        {
            this.Nama = Nama;
            this.Nim = Nim;
        }
    }
}
