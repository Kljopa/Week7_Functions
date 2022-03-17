using System;

namespace Functions
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sisesta esimest arvu:");
            int userNumberOne = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Sisesta teist arvu:");
            int userNomberTwo = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Vali tehe (sisesta '+', '-', '*', vÕi '/')");
            char userOperator = Convert.ToChar(Console.ReadLine());

            switch (userOperator) 
            {
                case '+':
                    AddTwoNumbers(userNumberOne, userNomberTwo);
                    break;
                case '-':
                    SubtractTwoNumbers(userNumberOne, userNomberTwo);
                    break;
                case '*':
                    IncreaseTwoNumbers(userNumberOne, userNomberTwo);
                    break;
                case '/':
                    DivideTwoNumbers(userNumberOne, userNomberTwo);
                    break;
                default:
                    Console.WriteLine("Kena päeva!");
                    break;
            }
        }

        public static void AddTwoNumbers(int x, int y)
        {
            int result = x + y;
            Console.WriteLine(result);
        }

        public static void SubtractTwoNumbers(int x, int y)
        {
            int result = x - y;
            Console.WriteLine(result);
        }

        public static void IncreaseTwoNumbers(double x, double y)
        {
            double result = x * y;
            Console.WriteLine(result);
        }

        public static void DivideTwoNumbers(double x, double y)
        {
            double result = x / y;
            Console.WriteLine(result);
        }

    }
}
