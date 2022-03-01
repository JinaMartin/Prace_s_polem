using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,,] pole3D =
            {
                {
                    {1, 1, 1},
                    {2, 2, 2},
                    {3, 3, 3}
                },
                {
                    {4, 4, 4},
                    {5, 5, 5},
                    {6, 6, 6}
                },
                {
                    {7, 7, 7},
                    {8, 8, 8},
                    {9, 9, 9}
                }
            };

            int[,] pole2D =
            {
                {1, 2, 3 },
                {4, 5, 6 },
                {7, 8, 9 },
                {10, 11, 12 },
                {13, 14, 15 }
            };

            int mujInt = SoucetSloupce(pole2D, 0);
            Console.WriteLine(mujInt);

            int[] velikostPole = Dimenze3DPole(pole3D);
            foreach (int item in velikostPole)
            {
                Console.Write(item + " ");
            }

            Console.ReadLine();
        }

        public static int SoucetSloupce(int[,] A, int i)
        {
            int pocetRadku = A.GetLength(0);
            int pocetSloupcu = A.GetLength(1);
            int soucet = 0;
            if (pocetSloupcu >= i)
            {
                for (int j = 0; j < pocetRadku; j++)
                {
                    soucet += A[j, i];
                }
            }
            else { throw new ArgumentException("Sloupec neexistuje."); }
            return soucet;
        }

        public static int[] Dimenze3DPole(int[,,] pole)
        {
            int x = pole.GetLength(0);
            int y = pole.GetLength(1);
            int z = pole.GetLength(2);
            int[] velikostPole = { x, y, z };
            return velikostPole;
        }
    }
}
