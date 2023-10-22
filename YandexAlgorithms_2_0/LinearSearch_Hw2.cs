//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Runtime.InteropServices;
//using System.Text;
//using System.Threading.Tasks;

//namespace YandexAlgorithms_2_0
//{
//    public class LinearSearch_Hw2
//    {

//        //Задача A
//        ///
//        //public static void A_Solution()
//        //{
//        //    string str = "";
//        //    string tempStr = "";

//        //    while (tempStr != "0")
//        //    {
//        //        tempStr = "";
//        //        tempStr = Console.ReadLine();
//        //        str += tempStr + " ";
//        //    }

//        //    string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        //    int num = strMas.Length;

//        //    int[] intMas = new int[num];
//        //    for (int i = 0; i < num; i++)
//        //    {
//        //        int.TryParse(strMas[i], out intMas[i]);
//        //    }

//        //    int maxPos = 0;
//        //    int max = intMas[maxPos];
//        //    for (int i = 1; i < intMas.Length; i++)
//        //    {
//        //        if (intMas[i] >= max)
//        //        {
//        //            max = intMas[i];
//        //            maxPos = i;
//        //        }
//        //    }
//        //    int count_result = 0;
//        //    for (int i = 0; i < intMas.Length; i++)
//        //    {
//        //        if (intMas[i] == max)
//        //        {
//        //            count_result++;
//        //        }
//        //    }
//        //    Console.WriteLine(count_result);
//        //}



//        //Задача B
//        //
//        //public static void B_Solution(string str)
//        //{
//        //    string[] strMas = str.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        //    int[] intMas = new int[strMas.Length];
//        //    for (int i = 0; i < intMas.Length; i++)
//        //    {
//        //        int.TryParse(strMas[i], out intMas[i]);
//        //    }
//        //    List<int> distances = new List<int>();
//        //    for (int i = 0; i < intMas.Length; i++)
//        //    {
//        //        if (intMas[i] == 1) 
//        //        {
//        //            bool flag_plus = false;
//        //            bool flag_minus = false;

//        //            int pos_plus = i;
//        //            while (intMas[pos_plus] != 2)
//        //            {
//        //                if (pos_plus == 9)
//        //                {
//        //                    flag_plus = true;
//        //                    break;
//        //                }
//        //                else { pos_plus++; }
//        //            }

//        //            int pos_minus = i;
//        //            while (intMas[pos_minus] != 2)
//        //            {
//        //                if (pos_minus == 0)
//        //                {
//        //                    flag_minus = true;
//        //                    break;
//        //                }
//        //                else { pos_minus--; }
//        //            }

//        //            if(flag_plus == false && flag_minus == true)
//        //            {
//        //                distances.Add(pos_plus - i);
//        //            }
//        //            else if (flag_plus == true && flag_minus == false)
//        //            {
//        //                distances.Add(i - pos_minus);
//        //            }
//        //            else
//        //            {
//        //                distances.Add(Math.Min(i - pos_minus, pos_plus - i));
//        //            }
//        //        }
//        //    }
//        //    Console.WriteLine(distances.Max());
//        //}

//        //Задача C
//        //public static void C_Solution(string str)
//        //{
//        //    char[] charMas = str.ToCharArray();
//        //    int count = 0;
//        //    for (int i = 0; i < (charMas.Length / 2); i++)
//        //    {
//        //        if (charMas[i] != charMas[charMas.Length - 1 - i])
//        //        {
//        //            count++;
//        //        }
//        //    }
//        //    Console.WriteLine(count);
//        //}



//        //Задача D
//        //
//        //public static void D_Solution(string firstStr, string secondStr)
//        //{
//        //    int resultRight = 0;
//        //    int resultLeft = 0;

//        //    string[] firstStrMas = firstStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//        //    string[] secondStrMas = secondStr.Split(' ', StringSplitOptions.RemoveEmptyEntries);

//        //    int[] firstIntMas = new int[2];
//        //    int.TryParse(firstStrMas[0], out firstIntMas[0]);
//        //    int.TryParse(firstStrMas[1], out firstIntMas[1]);

//        //    int[] secondIntMas = new int[firstIntMas[1]];
//        //    for (int i = 0; i<secondIntMas.Length; i++)
//        //    {
//        //        int.TryParse(secondStrMas[i], out secondIntMas[i]);
//        //    }
//        //    int mediumRightPos = firstIntMas[0] / 2;

//        //    bool flag_Right = false;
//        //    bool flag_Left = false;

//        //    for (int i = 0; i < secondIntMas.Length; i++)
//        //    {
//        //        if (secondIntMas[i] >= mediumRightPos && flag_Right == false)
//        //        {
//        //            resultRight = secondIntMas[i];
//        //            flag_Right = true;
//        //            break;
//        //        }
//        //    }
//        //    for (int i = secondIntMas.Length - 1; i >= 0; i--)
//        //    {
//        //        if (secondIntMas[i] < mediumRightPos && flag_Left == false)
//        //        {
//        //            resultLeft = secondIntMas[i];
//        //            flag_Left = true;
//        //            break;
//        //        }
//        //    }

//        //    string result = (resultRight == mediumRightPos && firstIntMas[0] % 2 == 1) ? resultRight.ToString() : 
//        //        resultLeft.ToString() + " " + resultRight.ToString();
//        //    Console.WriteLine(result);
//        //}

//        public static void E_Solution(string strCountFolders, string strDiplomas)
//        {
//            string[] strDiplomasMas = strDiplomas.Split(' ', StringSplitOptions.RemoveEmptyEntries);
//            List<int> intDiplomasMas = new List<int>();
//            for (int i = 0; i < strDiplomasMas.Length; i++)
//            {
//                int.TryParse(strDiplomasMas[i], out int tempDip);
//                intDiplomasMas.Add(tempDip);
//            }
//            int maxLast = intDiplomasMas.Max();
//            if (intDiplomasMas.Count == 1)
//            {
//                Console.WriteLine(0);
//            }
//            else
//            {
//                intDiplomasMas.Remove(maxLast);
//                Console.WriteLine(intDiplomasMas.Sum());

//            }
//        }


//        public static void Main(string[] args)
//        {
//            //Задача A
//            //
//            //A_Solution();

//            //Задача B
//            //
//            //B_Solution(Console.ReadLine());

//            //Задача C
//            //
//            //C_Solution(Console.ReadLine());

//            //Задача D
//            //
//            //D_Solution(Console.ReadLine(), Console.ReadLine());

//            //Задача E
//            //
//            E_Solution(Console.ReadLine(), Console.ReadLine());

//        }
//    }
//}
