using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1delewhocares
{
    public delegate bool Comparator(int[] A, int[] B);

    public class Kek {
        private Comparator _comparator;

        public Kek(Comparator comparator) {
            _comparator = comparator;
        }
        public bool setComparator(Comparator comparator) {
            _comparator = comparator;
            return _comparator == null;
        }
        public void Sort(int[][] mas, bool Inc)
        {
            for (int i = 0; i < mas.GetLength(0); i++)
                for (int j = i + 1; j < mas.GetLength(0); j++)
                {
                   if (bool.Equals(_comparator(mas[j - 1], mas[j]) , Inc) ) {
                        int[] B = mas[j];
                        mas[j] = mas[i];
                        mas[i] = B;
                    }
                }
        }






    }
    public class CompareFunctions{

        static public void cout(int[][] mas) {
            Console.WriteLine();
            for (int i = 0; i < mas.Length; i++)
            {
                for (int j = 0; j < mas[i].Length; j++)
                {
                    Console.Write(mas[i][j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
        static public bool SumSort(int[] A, int[] B)
         {
            int sumA = 0, sumB = 0;
            for (int i = 0; i < A.Length; i++)
            {
                sumA += A[i];
            }
            for (int i = 0; i < B.Length; i++)
            {
                sumB += B[i];
            }

            return sumA > sumB;
         }

        static public bool MaxSort(int[] A, int[] B)
    {
        int maxA = A[0], maxB = B[0];
        for (int i = 0; i < A.Length; i++)
        {
            if (maxA < A[i]) maxA = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            if (maxB < B[i]) maxB = B[i];
        }

        return maxA > maxB;
    }
        static public bool MinSort(int[] A, int[] B)
    {
        int minA = A[0], minB = B[0];
        for (int i = 0; i < A.Length; i++)
        {
            if (minA > A[i]) minA = A[i];
        }
        for (int i = 0; i < B.Length; i++)
        {
            if (minB > B[i]) minB = B[i];
        }

        return minA > minB;
    }
}
    class Program
    {

        static void Main(string[] args)
        {
            int[][] mas = new int[4][];
            mas[0] = new int[3] { 1, 300,  1004 };           
            mas[1] = new int[3] { 2, 400,  1003 };
            mas[2] = new int[3] { 3, 500,  1002 };
            mas[3] = new int[3] { 4, 200,  1001 };


            Kek kek = new Kek(CompareFunctions.SumSort);
            kek.Sort(mas, true);
            Console.WriteLine("SumSort INC");
            CompareFunctions.cout(mas);

            kek.Sort(mas, false);
            Console.WriteLine("SumSort DEC");
            CompareFunctions.cout(mas);


            kek.setComparator(CompareFunctions.MaxSort);

            kek.Sort(mas, true);
            Console.WriteLine("MaxSort INC");
            CompareFunctions.cout(mas);

            kek.Sort(mas, false);
            Console.WriteLine("MaxSort DEC");
            CompareFunctions.cout(mas);


            kek.setComparator(CompareFunctions.MinSort);
           
            kek.Sort(mas, true);
            Console.WriteLine("MinSort INC");
            CompareFunctions.cout(mas);

            kek.Sort(mas, false);
            Console.WriteLine("MinSort DEC");
            CompareFunctions.cout(mas);

            Console.ReadLine();

        }
    }
}
