using System;
using System.Collections.Generic;


namespace basic13
{
    class Program
    {

        public static void Print1to255()
        {
            for(int val = 1; val < 256; val++)
            {
                System.Console.WriteLine(val);
            }
        }

        public static void PrintOdds()
        {
            for(int val = 1; val < 256; val++)
            {
                if(val % 2 != 0)
                {
                    System.Console.WriteLine(val);
                }
            }
        }

        public static void PrintSum()
        {
            int sum = 0;
            for(int val = 1; val < 256; val++)
            {
                sum += val;
                System.Console.WriteLine($"New number: {val} Sum: {sum}");
            }
        }

        public static void iterateArray(int[] arr)
        {
            string output = "";
            for(int idx = 0; idx < arr.Length; idx++)
            {
                output += arr[idx] + " ";
                
            }
            System.Console.WriteLine(output);
        }

        public static void findMax(int[] arr)
        {
            int max = arr[0];
            for(int idx = 0; idx < arr.Length; idx++)
            {
                if(arr[idx] > max)
                {
                    max = arr[idx];
                }
            }
            System.Console.WriteLine(max);
        }

        public static void getAverage(int[] arr)
        {
            double sum = 0;
            double avg = 0;
            for(int idx = 0; idx < arr.Length; idx++)
            {
                sum += arr[idx];
                avg = sum / arr.Length;
            }
            System.Console.WriteLine(avg);
        }

        public static int[] arrayOddNumbers()
        {
            List<int> oddlist = new List<int>();
            for(int val = 1; val < 256; val++)
            {
                if(val % 2 == 1)
                {
                    oddlist.Add(val);     
                } 
            }
            return oddlist.ToArray();
        }

        public static void greaterThanY(int[] arr, int y)
        {
            int count = 0;
            foreach(int val in arr)
            {
                if(val > y)
                {
                    count++;
                }
            }
            System.Console.WriteLine(count);
        }

        public static void squareValues(int[] arr)
        {
            for(int val = 0; val < arr.Length; val++)
            {
                arr[val] = arr[val] * arr[val];
                System.Console.WriteLine(arr[val]);
            }
        }

        public static void eliminateNegatives(int[] arr)
        {
            for(int val = 0; val < arr.Length; val++)
            {
                if(arr[val] < 0)
                {
                    arr[val] = 0;
                }
                System.Console.Write(arr[val] + " ");
                
            }
            System.Console.WriteLine();
        }

        public static void minMaxAvg(int[] arr)
        {
            int max = arr[0];
            int min = arr[0];
            double sum = 0;
            double avg = 0;
            for(int val = 0; val < arr.Length; val++)
            {
                if(arr[val] > max)
                {
                    max = arr[val];
                }
                if(arr[val] < min)
                {
                    min = arr[val];
                }
                sum += arr[val];
                avg = sum / arr.Length;
            }
            System.Console.WriteLine(max);
            System.Console.WriteLine(min);
            System.Console.WriteLine(avg);
        }

        public static void shiftingArray(int[] arr)
        {
            for(int val = 0; val < arr.Length - 1; val++)
            {
                arr[val] = arr[val + 1];
            }
            arr[arr.Length - 1] = 0;
        }

        public static object[] numberWithString(object[] arr)
        {
            for(int val = 0; val < arr.Length; val++)
            {
                if((int)arr[val] < 0)
                {
                    arr[val] = "Dojo";
                }
                System.Console.WriteLine(arr[val]);
            }
            return arr;
            
        }





        static void Main(string[] args)
        {
            Print1to255();
            PrintOdds();
            PrintSum();
            int[] myArr = new int[6] {1,3,5,7,9,13};
            iterateArray(myArr);
            int[] maxArray = new int[3] {3,0,-7};
            findMax(maxArray);
            int[] avgArray = new int[5] {1,7,5,9,4};
            getAverage(avgArray);
            arrayOddNumbers();
            greaterThanY(myArr,6);
            squareValues(myArr);
            eliminateNegatives(maxArray);
            minMaxAvg(myArr);
            shiftingArray(myArr);
            object[] objectArray = new object[3] {3,0,-7};
            numberWithString(objectArray);
            Console.WriteLine("Hello World!");
        }
    }
}
