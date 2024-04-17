//14. Menghitung Jumlah Kata dalam Teks
using System;

class Hitungkata{
    static void Main(){
        Console.WriteLine("===Menghitung Jumlah Kata dalam Teks===");
        Console.WriteLine("Masukkan teks:");
        string teks = Console.ReadLine();

        int jumlahKata = HitungJumlahKata(teks);

        Console.WriteLine("Jumlah kata dalam teks adalah: " + jumlahKata);
    }

    static int HitungJumlahKata(string teks)
    {
        char[] pemisah = new char[] { ' ', '\r', '\n', '\t' };
        return teks.Split(pemisah, StringSplitOptions.RemoveEmptyEntries).Length;
    }
}