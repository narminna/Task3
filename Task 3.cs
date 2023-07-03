using System;

namespace ConsoleApp8
{
    public class MathHelper
    {
        public int PrintValue(int num1, int num2)
        {
            return num1 + num2;
        }

        public int PrintValue(bool value)
        {
            if (value)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }

        public void PrintValue(string str1, string str2)
        {
            string res = str1 + str2;
            Console.WriteLine(res);
        }

        public int PrintValue(int num1, int num2, int num3)
        {
            return num1 * num2 * num3;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            MathHelper mathHelper = new MathHelper();
            int sum = mathHelper.PrintValue(2, 3);
            Console.WriteLine(sum);

            int boolResult = mathHelper.PrintValue(true);
            Console.WriteLine(boolResult);

            mathHelper.PrintValue("Get", "Away");

            int multiplication = mathHelper.PrintValue(2, 3, 4);
            Console.WriteLine(multiplication);
        }
    }
}
