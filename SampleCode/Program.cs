using System;
using System.Text;

namespace SampleCode
{
    public static class StringHelper
    {
        /// <summary>
        /// This will return the full string reversed
        /// </summary>
        /// <param name="ins"></param>
        /// <returns></returns>
        public static string ReverseString(string ins)
        {
            char[] charArry = ins.ToCharArray();
            StringBuilder s = new StringBuilder();
            for (int i = (ins.Length - 1); i >= 0; i--)
            {
                s.Append(charArry[i]);
            }
            return s.ToString();
        }
        /// <summary>
        /// This will return the reverse word in string
        /// </summary>
        /// <param name="ins"></param>
        /// <returns></returns>
        public static string ReverseStringAsArr(string ins)
        {
            string[] splitArr = ins.Split(' ');
            StringBuilder s = new StringBuilder();
            for (int i = 0; i < splitArr.Length; i++)
            {
                char[] myArr = splitArr[i].ToCharArray();
                Array.Reverse(myArr);
                s.Append(new string(myArr));
                if (i < splitArr.Length - 1)
                    s.Append(" ");
            }
            return s.ToString();
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            string ipt = "this is reverse test";
            string result = StringHelper.ReverseString(ipt);
            Console.WriteLine(result);
            Console.WriteLine();
            Console.WriteLine(StringHelper.ReverseStringAsArr(ipt));
            Console.ReadKey();
        }
    }
}
