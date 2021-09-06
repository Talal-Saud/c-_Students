using System;

namespace my_C
{
    class Program
    {
        static void Main(string[] args)
        {
             int[] num = new int[5];
            num[0] = 44;
            num[1] = 45;
            num[2] = 555;
            num[3] = 88;
            num[4] = 74;
           

            Console.WriteLine(num.LongLength);
        }
    }
}
