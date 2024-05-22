using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            int toplam = 0;
            int toplam2 = 0;
            int[,] dizi = new int[3, 3];
            Random rnd = new Random();
            Console.WriteLine("1. dizi : \n");
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int random = rnd.Next(1, 9);
                    dizi[i, j] = random;
                    toplam = dizi[i, j] + toplam;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\n2. dizi : \n");
            int[,] dizi2 = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    int random2 = rnd.Next(1, 9);
                    dizi2[i, j] = random2;
                    toplam2 = dizi2[i, j] + toplam2;
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi2[i, j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine("\nİki dizinin toplamı : \n");
            int[,] dizi_toplam = new int[3, 3];
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    dizi_toplam[i, j] = dizi[i, j] + dizi2[i, j];
                    //Console.WriteLine(dizi2[i,j]);
                    //Console.WriteLine(dizi[i, j]);
                }
            }
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Console.Write(dizi_toplam[i, j] + " ");
                }
                Console.WriteLine();
            }
            int toplamSon = toplam + toplam2;
            Console.WriteLine("\nİki dizideki sayıların toplamı : " + toplamSon);
            Console.ReadLine();

        }
    }
}
