using System;
namespace test3
{
    class exercise
    {
        public static char Menu()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("A - Pounds to Kilograms");
            Console.WriteLine("B - Miles to Kilometers");
            Console.WriteLine("X - Exit");
            Console.WriteLine("-------------------------------");
            Console.WriteLine("This is a case-sensitive menu. ");
            Console.WriteLine("-------------------------------");
            char ch = Console.ReadLine()[0];
            return ch;
        }
        public static double PoundsToKilograms(double lbs)
        {
            return lbs * 0.45359237;
        }
        public static void MilesToKilometers(double miles, out double ans)
        {
            ans = miles * 1.609344;
        }
        // OptionA
        public static void OptionA()
        {
            double lbs = 200.0;
            while (lbs >= 50.0)
            {
                Console.WriteLine("Lbs: " + lbs + ", Kgs: "
                 + PoundsToKilograms(lbs));
                lbs -= 5.0;
            }
        }
        // OptionB
        public static void OptionB()
        {
            double miles = 10.0;
            double kms = 0.0;
            while (miles <= 100.0)
            {
                MilesToKilometers(miles, out kms);
                Console.WriteLine("Miles: " + miles + ", Kms: " + kms);
                miles += 10.0;
            }
        }
        public static void Main(String[] args)
        {
            char ch = 'z';
            while (ch != 'X')
            {
                ch = Menu();
                switch (ch)
                {
                    case 'A':
                        OptionA();
                        break;
                    case 'B':
                        OptionB();
                        break;
                    case 'X':
                        break;
                    default:
                        Console.WriteLine("Invalid option...");
                        break;
                }
            }
        }
    }
}


