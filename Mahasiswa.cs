using System;

namespace CobaClassObject
{
    public class Mahasiswa
    {
        //properties
        public string NIM { get; set; }
        public string Nama { get; set; }
        public float IPK { get; set; }

        //method
        public void Registrasi()
        {
            Console.WriteLine("Nama : {0}", Nama);
            Console.WriteLine("NIM  : {0}", NIM);
            Console.WriteLine("IPK : {0}", IPK);
            Console.WriteLine("Telah melakukan registrasi");
        }

        //method juga
        public void IsiKRS()
        {
            Console.WriteLine("{0} sedang melakukan proses KRS\n", Nama);
        }
    }
}
