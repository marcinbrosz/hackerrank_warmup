using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hackerrank_warmup
{
    class Program
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            return ar.Sum();
        }
        static int simpleArraySum(int n, int[] ar)
        {
            return ar.Sum();
        }
        static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
        {

            return new int[2] {score(a0,b0)+score(a1,b1)+score(a2,b2)
                               ,score(b0,a0)+score(b1,a1)+score(b2,a2)};
        }

        static int score(int a, int b)
        {
            return a > b ? 1 : 0;
        }

        static int Diagonal_Diff(int[][] a, int n)
        {
            int result = 0;
            //simple diagonal
            /*
            int j = n-1;
            for (int i = 0; i < n; i++)
            {
                result += a[i][i] - a[i][j - i];
            }*/

            //search diagonal
            bool isSearchDiag = false;//when the array is NxM
            bool isSimleDiag = false;//when the array is MxM

            for (int i = 0; i < n; i++)
            {
                if (a[i].Length == n - i)
                {
                    if (i == 0)
                        isSimleDiag = true;
                    else
                        isSearchDiag = true;
                }

                if (isSearchDiag)
                    result += a[i][i - 1] - a[i][n - i - 1];

                if (isSimleDiag)
                    result += a[i][i] - a[i][n - 1 - i];
            }

            return Math.Abs(result);
        }

        //1 possitive, -1 negative, 0 zeros
        static double plusMinus(int[] arr, int mode, int n)
        {

            return (mode == 1 ?
                    arr.Select(x => x > 0 ? 1.0 : 0).Sum() :
                    mode == 0 ?
                    arr.Select(x => x == 0 ? 1.0 : 0).Sum() :
                    arr.Select(x => x < 0 ? 1.0 : 0).Sum()) / n;
        }
        static string[] Staircase(int n)
        {

            string text = string
                            .Join("1", Enumerable.Range(0, n)
                            .Select(i => string.Concat(Enumerable.Range(0, n)
                            .Select(j => j >= (n - 1) - i ? '#' : ' '))));

            return text.Split('1');
        }


        static Int64 minSpecSum(int[] x)
        {
            int n = x.Length;

            return Convert.ToInt64(Enumerable.Range(0, n).Select(i =>
                         Enumerable.Range(0, n).Select(j => j != i ? x[j] : 0).Sum()).Min());
        }
        static Int64 maxSpecSum(int[] x)
        {
            int n = x.Length;
            return Convert.ToInt64(Enumerable.Range(0, n).Select(i =>
                          Enumerable.Range(0, n).Select(j => j != i ? x[j] : 0).Sum()).Max());
        }

        static int birthdayCakeCandles(int n, int[] ar)
        {
            int result = 0;
            int max = ar.Max();
            for (int i = 0; i < n; i++)
            {
                if (ar[i] == max)
                    result++;
            }
            return result;//ar.Select(x => x == ar.Max() ? 1 : 0).Sum();
        }


        static string timeConversion(string s)
        {
            DateTime temp =
                DateTime.ParseExact(s, "hh:mm:sstt", System.Globalization.CultureInfo.InstalledUICulture);


            return temp.ToString("HH:mm:ss");
        }

        static void Main(String[] args)
        {
            //for solve
            //string[] tokens_a0 = Console.ReadLine().Split(' ');
            //int a0 = Convert.ToInt32(tokens_a0[0]);
            //int a1 = Convert.ToInt32(tokens_a0[1]);
            //int a2 = Convert.ToInt32(tokens_a0[2]);
            //string[] tokens_b0 = Console.ReadLine().Split(' ');
            //int b0 = Convert.ToInt32(tokens_b0[0]);
            //int b1 = Convert.ToInt32(tokens_b0[1]);
            //int b2 = Convert.ToInt32(tokens_b0[2]);
            //int[] result = solve(a0, a1, a2, b0, b1, b2);
            //Console.WriteLine(String.Join(" ", result));
            //
            //for simpleArraySum
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ar_temp = Console.ReadLine().Split(' ');
            //int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
            //int result = simpleArraySum(n, ar);
            //Console.WriteLine(result);
            //
            //for aVeryBigSum 
            //int n = Convert.ToInt32(Console.ReadLine());
            //string[] ar_temp = Console.ReadLine().Split(' ');
            //long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            //long result = aVeryBigSum(n, ar);
            //Console.WriteLine(result);
            //
            //for Diagonal_Diff
            /*const int n = 4;
            int[][] a = new int[n][] { new int[] { 3 }, new int[] { 11, 2, 4 }
                      , new int[] { 4, 5, 6 }, new int[] { 10, 8, -12 } };

            Console.WriteLine(Diagonal_Diff(a, n));*/

            //for plus minus
            /*
            int n = Convert.ToInt32(Console.ReadLine());
            string[] arr_temp = Console.ReadLine().Split(' ');
            int[] arr = Array.ConvertAll(arr_temp, Int32.Parse);*/
            //int[] arr = { -4, 3, -9, 0, 4, 1 };
            //int n = 6;

            //Console.WriteLine(plusMinus(arr, 1,n).ToString("0.000000"));
            //Console.WriteLine(plusMinus(arr, -1, n).ToString("0.000000"));
            //Console.WriteLine(plusMinus(arr, 0, n).ToString("0.000000"));


            //for Staircase
            //Staircase(15).ToList().ForEach(Console.WriteLine);
            //Console.WriteLine( Staircase(5));


            //for min and max sum
            //int n = 5;
            //int[] arr = new int[5]{ 1,2,3,4,5 };
            //Array.Sort(arr);
            //long min = 0;
            //long max = 0;


            //for (int i = 0; i < n - 1; i++)
            //{
            //    min += arr[i];
            //    max += arr[i + 1];
            //}

            //Console.WriteLine(min+ " "+max);
            //Console.WriteLine(minSpecSum(arr) +" "+ maxSpecSum(arr));

            //for birsdaycake
            /*int n = 5;
            int[] arr = new int[] { 1, 2, 3, 4, 5 };*/

            //for Time Conversion 12 to 24
            timeConversion("07:05:45PM");

            Console.Read();
        }
    }
}
