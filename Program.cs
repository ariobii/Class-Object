using System;

namespace CobaClassObject
{
    class Program
    {
        static void Main(string[] args)
        {
            //buat objek 
            Mahasiswa Aulia = new Mahasiswa();
            Mahasiswa Hasbi = new Mahasiswa();

            //set nilai properties
            Aulia.NIM = "18.11.2279";
            Aulia.Nama = "Aulia Ariobimo";
            Aulia.IPK = 4.5f;

            Hasbi.NIM = "18.11.2252";
            Hasbi.Nama = "Hasbi Ash Shiddiq";
            Hasbi.IPK = 5.5f;

            //memanggil method
            Aulia.Registrasi();
            Aulia.IsiKRS();

            Hasbi.Registrasi();
            Hasbi.IsiKRS();

            Console.ReadKey();
        }
    }
}
