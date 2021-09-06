using System;

namespace Project_Students
{
    class Project_Students
    {

        static void Main(string[] args)
        {
            int number;
            do
            {
                Console.WriteLine("Enter number Students : ");
                number = int.Parse(Console.ReadLine());
            }
            while (number <= 0);


            string[] name = new string[number];
            int[] mark = new int[number];

            for (int i = 0; i < number; i++)
            {
                Console.WriteLine("Enter Name : ");
                name[i] = Console.ReadLine();
                Console.WriteLine("Enter Mark : ");
                mark[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.WriteLine("==============================");

            for (int i = 0; i < number; i++)
            {
                if (mark[i] >= 60)
                {
                    Console.WriteLine(" {0} is Passed ", name[i]);
                }
                else if (mark[i] < 60)
                {
                    Console.WriteLine(" {0} is Failed  ", name[i]);
                }
                else
                {
                    Console.WriteLine("Not Found !");
                }
            }



        }


    }
}