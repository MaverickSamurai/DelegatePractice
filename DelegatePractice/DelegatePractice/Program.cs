using System;
using System.Collections.Generic;

namespace DelegatePractice
{
    class Program
    {
        //public delegate void ChangeString(string str);

        //public delegate string StringLength(string str, int m);

        //public delegate bool CheckNums(int num);
        static void Main(string[] args)
        {


            #region Predicate, Action
            //int[] arr = { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            //Console.WriteLine(Sum(CheckOdd, arr));


            //Console.WriteLine(Sum(CheckEven, arr));

            //Console.WriteLine(Sum(CheckThanFive, arr));

            //List<int> numbers =  new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            //var result = numbers.FindAll(/*m => m > 6 && m < 9*/ CheckThanFive);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}

            //Test(StringToUpper, "Cavid");
            //Test(StringToLower, "Cavid");

            //ChangeString change = new ChangeString(StringToLower);
            //change.Invoke("Mirsamir");

            //Int32 num = new Int32();
            //num = 33;
            //Console.WriteLine(num);

            //int num1 = 44;

            //String str = new String("Abdulla");
            //string name = "Abdulla";
            //Console.WriteLine(str);

            //ChangeString change = StringToLower;
            //change.Invoke("Mirsamir");

            //change += StringToUpper;

            //change += delegate (string s)
            //{
            //    Console.WriteLine(s.ToLower()); 
            //};

            //change += s => Console.WriteLine(s.ToLower());

            //change("Mirsamir");


            //Action<string, int, string> action = StringToUpper;

            //action += delegate (string s, int m, string c)
            //{
            //    Console.WriteLine(s.ToLower() + "-" + m + c);
            //};

            //action += StringToLower;

            //action("Mirsamir", 22, "P130");



            #endregion


            #region Func
            //Test(StrLength, "Mirsamir");

            //Console.WriteLine(Test(StrLength, "Mirsamir", 22));

            //Func<string, int, string> func = StrLength;

            //Func<string, int, int> func2 = StrLength2;

            //Console.WriteLine(func("Mirsamir", 22));

            //Console.WriteLine(func2("Mirsamir", 22));
            #endregion
        }

        #region Delegates
        //public static int StrLength2(string str, int m)
        //{

        //    return str.Length + m;
        //}

        //public static string StrLength(string str, int m)
        //{
        //    //return str.Length * m;

        //    return str.Length.ToString() + "-Age:" + m;
        //}

        //public static string Test(StringLength func, string str, int m)
        //{
        //    return func(str, m);
        //}

        //public static void StringToUpper(string word, int m, string t)
        //{
        //    Console.WriteLine(word.ToUpper() + "-" + m + t);
        //}


        //public static void StringToLower(string word, int m, string t)
        //{
        //    Console.WriteLine(word.ToLower() + "-" + m + t);
        //}


        //public static void Test(ChangeString func, string word)
        //{
        //    func(word);
        //}


        //public static bool CheckOdd(int number)
        //{

        //    return number % 2 != 0;

        //}

        //public static bool CheckEven(int number)
        //{

        //    return number % 2 == 0;

        //}

        //public static bool CheckThanFive(int number)
        //{

        //    return number > 6;

        //}

        //public static int Sum(Predicate<int> predicate, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (/*item % 2 != 0*/ predicate(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}



        //public static int Sum(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (/*item % 2 != 0*/ func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}



        //public static int SumEven(CheckNums func, int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (/*item % 2 == 0*/ func(item))
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}



        //public static int SumThanFive(int[] nums)
        //{
        //    var sum = 0;
        //    foreach (var item in nums)
        //    {
        //        if (/*item > 5*/)
        //        {
        //            sum += item;
        //        }
        //    }

        //    return sum;
        //}
    }

    #endregion

}
