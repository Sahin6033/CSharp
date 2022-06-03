using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace task2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            int[] nums = { 1, 2, 3, 6, 7, 778, 23, 78, 341, 12 };

            //*1
            //  Console.WriteLine( SumOfArraysItems(nums));//1

            //*2
            //int[] arr = SortArrayMaxToMin(nums);
            //for (int i = 0; i <arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}


            //*3
            //Console.WriteLine(MaxInArray(nums));


            //*4
            //Console.WriteLine(MinInArray(nums));

            //*5
            //MaxSumOfNums(nums);

            //*6
            //MinSumOfNums(nums);

            //*7
            // SquareOfAyyarItems(nums);

            //*8
            //Console.WriteLine(SumOfOddArrayItems(nums));

            //*9
            //Console.WriteLine(IsThreeDigitNumber(nums));


            //10*
            /*int[] oddsArray = NewOddsArray(nums);
            for (int i = 0; i < oddsArray.Length; i++)
            {
                Console.WriteLine(oddsArray[i]);
            } */


            //11*
           // ItemsOfNumbers(nums);



        }
        #region //1 Ədədlərin cəmini tapan metod yazın.
        public static int SumOfArraysItems (int[] arr)
        {
            int sum = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                 sum+=arr[i];
            }
            return sum;
        }
        #endregion


        #region //2 Ədədlərin böyükdən kiçiyə doğru sıralayan method yazin (istəyə bağlı)
        public static int[] SortArrayMaxToMin(int[] arr)
        {
            
            for (int i = 0; i < arr.Length; i++)
            {
                for (int j = i; j < arr.Length; j++)
                {
                    if(arr[i] > arr[j])
                    {
                        int temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
                
            }
            
            return arr;
        }
        #endregion


        #region //3 Ədədlər arasında ən böyü tapın.
        public static int MaxInArray(int[] arr)
        {
            int max = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (max < arr[i])
                {
                    max = arr[i];
                }
            }
            return max;
        }
        #endregion


        #region //4 Ədələrin arsında ən kiçiyi tapın.
        public static int MinInArray(int[] arr)
        {
            int min = arr[0];
            for (int i = 1; i < arr.Length; i++)
            {
                if (min > arr[i])
                {
                    min = arr[i];
                }
            }
            return min;
        }
        #endregion


        #region //5 Ədədlərin arasında rəqəmlərinin cəmi ən böyük olan ədədi tapın.
        public static void MaxSumOfNums(int[] arr)
        {
            int[] arrSums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                arrSums[i] = sum;
            }
            int maxIndex=0;
            int max = arrSums[0];
            for (int i = 1; i < arrSums.Length; i++)
            {
                if (max < arrSums[i])
                {
                    max = arrSums[i];
                    maxIndex = i;
                }
            }
            Console.WriteLine(arr[maxIndex]);

        }
        #endregion


        #region //6 Ədədlərin arasında rəqəmlərinin cəmi ən kiçik olan ədədi tapın.
        public static void MinSumOfNums(int[] arr)
        {
            int[] arrSums = new int[arr.Length];
            for (int i = 0; i < arr.Length; i++)
            {
                int number = arr[i];
                int sum = 0;
                while (number != 0)
                {
                    sum += number % 10;
                    number /= 10;
                }
                arrSums[i] = sum;
            }
            int minIndex = 0;
            int min = arrSums[0];
            for (int i = 1; i < arrSums.Length; i++)
            {
                if (min > arrSums[i])
                {
                    min = arrSums[i];
                    minIndex = i;
                }
            }
            Console.WriteLine(arr[minIndex]);

        }
        #endregion


        #region //7 Ədədlərin kvadratlarını ekrana yazdırın.
        public static void SquareOfAyyarItems (int[] arr)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]*arr[i]);
            }
        }
        #endregion


        #region //8 Tək ədədlərin cəmini tapan metod yazın və ekrana cap edin.
        public static int SumOfOddArrayItems(int[] arr)
        {
            int sum = 0;    
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    sum += arr[i];
                }
            }
            return sum;
        }
        #endregion


        #region //9 Daxilində 3 rəqəmi olan neçə ədəd olduğunu ekrana çap edən metod yazın
        public static int IsThreeDigitNumber(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int arrItem = arr[i];
                int numCounts = 0;
                while (arrItem != 0)
                {
                    numCounts++;

                    arrItem /= 10;
                }
                if (numCounts == 3)
                {
                    count++;
                }


            }
            return count;
        }
        #endregion


        #region //10 Tək ədədləri ayıraraq ayrıca bir massivə yığan metod yazın
        public static int[] NewOddsArray(int[] arr)
        {
            List<int> numList = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 != 0)
                {
                    numList.Add(arr[i]);
                }
            }
            int[] newArray = numList.ToArray();
            return newArray;
        }
        #endregion


        #region //11 Ədədin rəqəmlərini ekrana çıxaran method yazin.
        public static void ItemsOfNumbers(int[] arr)
        {
            int count = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                int arrItem = arr[i];

                while (arrItem != 0)
                {
                    Console.Write($"[{arrItem % 10}]");

                    arrItem /= 10;
                }
                Console.WriteLine();


            }
            
        }
        #endregion
    }
}
