using System;

namespace HomeWork._16._04
{
    class Program
    {
        static void Show<T>(T[] arra)
        {
            foreach(T w in arra)
            {
                System.Console.Write(w + " ");
            }
        }
        static void Main(string[] args)
        {
            string[] arra = {"5","4","3","2","1"};
            string[] arr = ArrayHelper.Slice<string>(arra);
            ArrayHelper.Pop<string>(ref arra);
            Show(arra);
            System.Console.WriteLine();
            Show(arra);
            ArrayHelper.Push<string>(ref arra,arra[0]);
            Show(arra);
            Console.ReadKey();
        }
    }
}
