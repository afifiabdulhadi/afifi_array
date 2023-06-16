using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class program
    {
        static void Main(string[] args)
        {
            int i, c;
            string[] nama = new string[3];
            string[] kelas = new string[3];
            string[] jurusan = new string[3];
            string[] alamat = new string[3];

            for (i = 0; i < 3; i++) 
            {
                c = i + 1;
                Console.WriteLine("INPUT " + c);
                Console.WriteLine("=============");
                Console.Write("NAMA         : ");
                nama[i] = Console.ReadLine();
                Console.Write("kelas        :");
                kelas[i] = Console.ReadLine();
                Console.Write("jurusan      :");
                jurusan[i] = Console.ReadLine();
                Console.Write("alamat       :");
                alamat[i] = Console.ReadLine();
                Console.WriteLine();


            }
            Console.WriteLine();
            Console.WriteLine("DATA TELAH DIMASUK KAN TEKAN SEMBARANG UNTUK MENAMPILKAN ");
            Console.ReadLine();
            Console.Clear();
            Console.WriteLine("BERIKUT INI DATA SISWA YANG DIMASUKKAN ");
            Console.WriteLine("==================");
            Console.WriteLine();
            Console.WriteLine("+-----------------+");
            Console.WriteLine("| NO | NAMA SISWA | KELAS       |          JURUSAN | alamat |");
            Console.WriteLine("+-----------------+");
            for (i = 0; i < 3; i++) 
            {
                c = i + 1;      
                Console.WriteLine("| " + c + "   | " + nama[i] + "        | " + kelas[i] + "       | " + jurusan[i] + "         | "+ alamat[i] + "   |" );

            }
            Console.WriteLine("+--------------------------------------------+");
            Console.WriteLine();
            Console.Write("TEKAN ENTER UNTUK KELUAR . . . .");
            Console.ReadLine();
        }

    }
}
   