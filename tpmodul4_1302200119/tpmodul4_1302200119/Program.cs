using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tpmodul4_1302200119
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string namaKu;
            Console.Write("Masukkan Nama: ");
            namaKu = Console.ReadLine();

            HaloGeneric.SapaUser<string>(namaKu);
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }
}
