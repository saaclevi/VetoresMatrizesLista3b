using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VetoresMatrizesLista3b
{
    internal class Program
    {
        private static object rand;

        static void Main(string[] args)
        {
            //vetores
            int[] v1 = new int[4] { 23, 56, 44, 11 };
            int[] v2 = { 34, 67, 100, 11, 12, 122 };

            Console.WriteLine("Vetor v1[1]:" + v1[1]);

            //matrizes
            int[,] matriz1 = new int[3, 4];
            Random rand= new Random();
            for(int i = 0; i< 3; i++)
            {
                for(int j =0; j < 4; j++)
                {
                    matriz1[i, j] = rand.Next(10);
                }
            }
            Console.WriteLine();
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matriz1[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            //listas
            List<string> list = new List<string>();
            list.Add("c");
            list.Add("java");
            list.Add("html");
            list.Add("php");

            for(int i = 0; i<4; i++)
            {
                Console.WriteLine(list[i]);
            }

            Console.ReadKey();
        }
    }
}
