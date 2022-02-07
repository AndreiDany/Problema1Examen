using System;

namespace Problema1Examen
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduceti numarul de elemente ale vectorului!");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] vector = new int[n];

            Console.WriteLine("Introduceti elementele vectorului!");
            for (int i = 0; i < vector.Length; i++)
            {
                Console.Write($"vector[{i}]= ");
                vector[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine(SumaElementeVector(vector, n));
        }

        static int SumaElementeVector(int[] vector, int n)
        {
            if (n == 1)
                return vector[0];
            else
                return vector[n - 1] + SumaElementeVector(vector, n - 1);
        }
    }
}
