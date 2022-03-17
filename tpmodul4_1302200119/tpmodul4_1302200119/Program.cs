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

            string data;
            Console.Write("Masukkan data: ");
            data = Console.ReadLine();

            DataGeneric<string> data1 = new DataGeneric<string>(data);
            data1.PrintData();
        }
    }

    class HaloGeneric
    {
        public static void SapaUser<T>(T nama)
        {
            Console.WriteLine("Halo user " + nama);
        }
    }

    class DataGeneric<T>
    {
        T data;
        public DataGeneric(T Data)
        {
            this.data = Data;
        }

        public void PrintData()
        {
            Console.WriteLine("Data yang tersimpan adalah: " + this.data);
        }
    }

}
