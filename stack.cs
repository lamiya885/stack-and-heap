using System.Reflection.Metadata.Ecma335;

namespace ConsoleApp10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 1, 2, 12, 13, 14, 15, 16 };
            İnsertArray(ref num, 23, 3, 4);
            foreach (int i in num)
            {
                Console.WriteLine(i);
            }
        }
        static void İnsertArray(ref int[] ary, params int[] ary2) 
        {
            int[] ButunEdedler = new int[ary.Length+ary2.Length];

            for (int j = 0; j < ary.Length; j++)
            {
                ButunEdedler[j] = ary[j];
               
            }

            for (int i = 0; i < ary2.Length; i++)
            {
                    int a = ary.Length + i ;
                    ButunEdedler[a] = ary2[i];
                  
            }
            
            
            
        }
    }
}
