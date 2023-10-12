using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace YandexAlgorithms_2_0
{
    public class Homework1
    {
        /*Первая таска
         */
        //public static int MySolutionFirst(int r, int i, int c)
        //{
        //    int responce;

        //    if (i == 0) { responce = (r != 0) ? 3 : c; }

        //    else if (i == 1) { responce = c; }

        //    else if (i == 4) { responce = (r != 0) ? 3 : 4; }

        //    else if (i == 6) { responce = 0; }

        //    else if (i == 7) { responce = 1; }

        //    else { responce = i; }

        //    return responce;
        //}




        /*Вторая таска
         */
        //public static void MySolutionSecond(string str)
        //{
        //    string[] date = str.Split(' ');
        //    int.TryParse(date[0], out int N);
        //    int.TryParse(date[1], out int i);
        //    int.TryParse(date[2], out int j);

        //    int n1 = N + Math.Min(i,j) - Math.Max(i,j) - 1;
        //    int n2 = Math.Max(i,j) - Math.Min(i,j) - 1;


        //    int count_station = Math.Min(n1, n2);

        //    Console.WriteLine(count_station);
        //}




        /*Третья таска*/
        //public static void MySolutionThird(string str)
        //{
        //    string[] inputNumbers = str.Split();
        //    if (inputNumbers.Length == 3)
        //    {
        //        if (int.TryParse(inputNumbers[0], out int a) &&
        //            int.TryParse(inputNumbers[1], out int b) &&
        //            int.TryParse(inputNumbers[2], out int c))
        //        {
        //            if (a == b)
        //            {
        //                Console.WriteLine(0);
        //            }
        //            else if (b <= 12 && a <= 12)
        //            {
        //                Console.WriteLine(0);
        //            }
        //            else
        //            {
        //                Console.WriteLine(1);
        //            }
        //        }
        //        else
        //        {
        //            Console.WriteLine("Ошибка ввода. Введите три целых числа.");
        //        }
        //    }
        //    else
        //    {
        //        Console.WriteLine("Ошибка ввода. Введите три целых числа, разделенных пробелами.");
        //    }
        //}



        /*Четвёртая таска*/
        //public static void MySolutionFourth(string Nstr, string str)
        //{

        //    int.TryParse(Nstr, out int N);
        //    string[] housesStr = str.Split(' ');
        //    int[] housesInt = new int[N];
        //    for (int i = 0; i < N; i++)
        //    {
        //        int.TryParse(housesStr[i], out housesInt[i]);
        //    }
        //    int res = housesInt[housesInt.Length / 2];

        //    Console.WriteLine(res);
        //}



        /*Пятая таска*/
        public static void MySolutionFith(string dStr, string XStr)
        {
            int.TryParse(dStr, out int d);
            string[] XmasStr = XStr.Split(' ');
            int.TryParse(XmasStr[0], out int x1);
            int.TryParse(XmasStr[1], out int x2);

            int[] a = { 0, 0 };
            int[] b = { d, 0 };
            int[] c = { 0, d };

            if ((x1 >= 0 && x2 >= 0) && (x1 + x2 <= d))
            {
                Console.WriteLine(0);
            }
            else
            {
                double[] dist = new double[3];

                dist[0] = Math.Sqrt(Math.Pow((a[0] - x1), 2) + Math.Pow((a[1] - x2), 2));
                dist[1] = Math.Sqrt(Math.Pow((b[0] - x1), 2) + Math.Pow((b[1] - x2), 2));
                dist[2] = Math.Sqrt(Math.Pow((c[0] - x1), 2) + Math.Pow((c[1] - x2), 2));

                int min_dis_pos = 2;
                double min_dist = dist[min_dis_pos];

                for (int i = 1; i >= 0; i--)
                {
                    if (dist[i] <= min_dist)
                    {
                        min_dist = dist[i];
                        min_dis_pos = i;
                    }
                }
                Console.WriteLine(min_dis_pos + 1);
            }
        }

        /// ///////////////////////////////////////////////////////////////////////////////

        //LeetCode
        //two sum
        //public static void TwoSum(int[] nums, int target)
        //{
        //    Hashtable dif = new Hashtable();
        //    int first;
        //    int second;
        //    int[] twoSum = new int[2];

        //    for (int i = 0; i < nums.Length; i++)
        //    {
        //        if (dif.ContainsKey(nums[i]))
        //        {
        //            twoSum[0] = (int)dif[nums[i]];
        //            twoSum[1] = i;
        //        }

        //        int tempDif;
        //        tempDif = target - nums[i];
        //        dif[tempDif] = i;
        //    }
        //    Console.WriteLine(twoSum[0] + " " + twoSum[1]);
        //}

        public static void Main(string[] args)
        {

            ///* Первая таска*/
            ///
            //string r = Console.ReadLine();
            //string i = Console.ReadLine();
            //string c = Console.ReadLine();
            //int.TryParse(r, out int number_r);
            //int.TryParse(i, out int number_i);
            //int.TryParse(c, out int number_c);
            ////Console.WriteLine(MySoolutionFirst(number_r, number_i, number_c));



            //Вторая таска
            ///
            //MySolutionSecond(Console.ReadLine());


            //Третья таска
            ///
            //MySolutionThird(Console.ReadLine());

            //Четвёртая таска
            ///
            //MySolutionFourth(Console.ReadLine(), Console.ReadLine());


            //Пятая таска
            ///
            MySolutionFith(Console.ReadLine(), Console.ReadLine());


            //TwoSum
            ///
            //int[] nums = { 3, 3};
            //int target = 6;
            //TwoSum(nums, target);
        }
    }
}
