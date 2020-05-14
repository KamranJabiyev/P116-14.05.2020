using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RefOutStringBuilder
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Value,reference - ref,out
            //int a = 10;
            //int b = a; //b=10
            //b = 100;
            //Console.WriteLine("a= "+a);
            //Console.WriteLine("b= "+b);

            //int[] arr1 = { 100, 200, 300 };
            //int[] arr2 = arr1; //arr2={100,200,300} eyni deyil !!!
            //arr2[0] = 1000;
            //int[] arr3 = arr1;
            //arr3[0] = 2000;
            //arr1[0] = 1234;
            //Console.WriteLine("arr1[0]= " + arr1[0]);
            //Console.WriteLine("arr2[0]= " + arr2[0]);

            //int a=10;
            //ChangeNum(ref a);
            //Console.WriteLine("deyishen = " + a);

            //int[] arr = { 10, 20, 30 };
            //Console.WriteLine("array= "+arr[0]);
            //ChangeIndex(arr);
            //Console.WriteLine("array= " + arr[0]);

            //string test = "123q";
            //int result;
            //bool isParse = int.TryParse(test,out result);
            //Console.WriteLine(isParse);
            //Console.WriteLine(result);
            #endregion

            #region StringBuilder
            //string word = "Kamran Jabiyev";
            //Console.WriteLine(StrReverse(word));
            //narmaK
            //StrReverse(word);

            //StringBuilder str = new StringBuilder("Kamran");
            //str.Append("Jabiyev");
            ////str.Clear();
            //str.Insert(6, " ");
            //str.Remove(6,8);
            //Console.WriteLine(str);

            #endregion
        }

        #region StringBuilder
        //static string StrReverse(string str)
        //{
        //    string result = "";
        //    for (int i = str.Length-1; i >=0; i--)
        //    {
        //        result += str[i];
        //    }
        //    return result;
        //}

        //static StringBuilder StrReverse(string str)
        //{
        //    StringBuilder result = new StringBuilder();
        //    for (int i = str.Length - 1; i >= 0; i--)
        //    {
        //        result.Append(str[i]);
        //    }
        //    return result;
        //}

        #endregion

        #region Value,reference - ref,out
        //static void ChangeIndex(int[] arr)
        //{
        //    arr[0] = 100;
        //    Console.WriteLine("method = "+arr[0]);
        //}

        //static void ChangeNum(ref int a)
        //{
        //    Console.WriteLine("method = " + a);
        //}


        #endregion


    }
}
