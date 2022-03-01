using System;
using System.Collections.Generic;


namespace SoloLearn
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = Convert.ToInt32(Console.ReadLine());
            string value = "";

            for (int i = 1; i <= number; i++)
            {
                if (i % 3 == 0)
                {
                    value = "*";
                }
                value = value + i.ToString();
            }
            Console.WriteLine(value);
        }
    }
}