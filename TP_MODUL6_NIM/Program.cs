using System;

namespace MusicApp
{
    public class SayaMusicTrack
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            this.title = title;

            Random rand = new Random();
            this.id = rand.Next(10000, 100000);

            this.playCount = "0";
        }

        public void IncreasePlayCount(int count)
        {
            int currentCount = int.Parse(this.playCount);
            int newCount = currentCount + count;
            this.playCount = newCount.ToString();
            Console.WriteLine($"Berhasil menambah {count} play.");
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("\n============================");
            Console.WriteLine($"TRACK ID    : {this.id}");
            Console.WriteLine($"TITLE       : {this.title}");
            Console.WriteLine($"PLAY COUNT  : {this.playCount}");
            Console.WriteLine("============================");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("--- Menginisialisasi Lagu Baru ---");
            SayaMusicTrack lagu = new SayaMusicTrack("Chop Suey!");

            lagu.PrintTrackDetails();

            Console.WriteLine("\n--- Menambahkan Play Count ---");
            lagu.IncreasePlayCount(14;
            lagu.IncreasePlayCount(69);

            lagu.PrintTrackDetails();

            Console.WriteLine("\nTekan tombol apa saja untuk keluar...");
            Console.ReadKey();
        }
    }
}