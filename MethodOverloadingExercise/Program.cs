using System;

namespace MethodOverloadingExercise
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Add(5, 6));
            Console.WriteLine(Add(12.56m, 16.27m));
            Console.WriteLine(Add(14, 17, true));

        }

        public static int Add(int num1, int num2)
        {
            return num1 + num2;
        }

        public static decimal Add(decimal num1, decimal num2)
        {
            return num1 + num2;
        }

        public static string Add(int num1, int num2, bool money)
        {
            int ans = num1 + num2;

            if (money)
            {
                if (ans == 1)
                {
                    return $"{ans} dollar";
                }
                else
                {
                    return $"{ans} dollars";
                }
            }
            else
            {
            return $"{ans}";
            }
        }
    }
}
