using System;
using System.Diagnostics;

namespace MusicApp
{
    public class SayaMusicTrack
    {
        private int id;
        private string playCount;
        private string title;

        public SayaMusicTrack(string title)
        {
            Debug.Assert(title != null, "Judul tidak boleh null");
            Debug.Assert(title.Length <= 100, "Judul maksimal 100 karakter");

            this.title = title;
            Random rand = new Random();
            this.id = rand.Next(10000, 100000);
            this.playCount = "0";
        }

        public void IncreasePlayCount(int count)
        {
            Debug.Assert(count <= 10000000, "Input maksimal 10.000.000");

            int currentCount = int.Parse(this.playCount);

            checked
            {
                try
                {
                    int newCount = currentCount + count;
                    this.playCount = newCount.ToString();
                }
                catch (OverflowException)
                {
                    throw new OverflowException();
                }
            }
        }

        public void PrintTrackDetails()
        {
            Console.WriteLine("----------------------------");
            Console.WriteLine($"ID    : {id}");
            Console.WriteLine($"Title : {title}");
            Console.WriteLine($"Plays : {playCount}");
            Console.WriteLine("----------------------------");
        }
    }

    class Program
    {
        public static void Main()
        {
            SayaMusicTrack lagu = new SayaMusicTrack("Chop Suey!");

            try
            {
                lagu.PrintTrackDetails();

                Console.WriteLine("\nMenambah 5.000.000 play...");
                lagu.IncreasePlayCount(5000000);

                Console.WriteLine("\nMenambah angka sangat besar untuk memicu Exception...");

                for (int i = 0; i < 250; i++)
                {
                    lagu.IncreasePlayCount(10000000);
                }
            }
            catch (OverflowException)
            {
                Console.WriteLine("Terjadi Error: Penambahan Play Count melebihi batas maksimum (Overflow).");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Terjadi kesalahan: " + ex.Message);
            }

            Console.WriteLine("\nProgram selesai running.");
            Console.ReadKey();
        }
    }
}