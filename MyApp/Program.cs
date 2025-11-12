using System;
using System.Linq;
using System.Transactions;

namespace MyApp
{
    class Program
    {


        static void PrintHello()
        {
            Console.WriteLine("Hello World!");
        }

        static void PrintRandom(string message, string defaultString = "Nguyen Cong ")
        {
            Console.WriteLine("Hello " + defaultString + message);
        }

        static int Sum(int a, int b)
        {
            return a + b;
        }

        static double Sum(double a, double b)
        {
            return a + b;
        }

        static void Main(string[] args)
        {
            // // string fullName = "Nguyen Cong Trinh Do";
            // string firtName = Console.ReadLine();
            // string lastName = Console.ReadLine();
            // string fullName = firtName + " " + lastName;
            // Console.WriteLine("Enter your age:");
            // int age = Convert.ToInt32(Console.ReadLine());
            // Console.WriteLine("Your age is: " + age);
            // Console.WriteLine("Hello, " + fullName);
            // const int myGradeInt = 10;
            // // const double myGradeDouble = myGradeInt;
            // Console.WriteLine("My grade is: " + Convert.ToDouble(myGradeInt));

            // Console.WriteLine(fullName.IndexOf("Cong"));
            // Console.WriteLine(fullName.LastIndexOf("n"));
            // Console.WriteLine(fullName.Substring(7, 4));
            // Console.WriteLine(fullName.Substring(fullName.IndexOf("Cong")));


            // Create an array of four elements, and add values later
            string[] cars1 = new string[4];
            cars1[0] = "Volvo";
            cars1[1] = "BMW";
            cars1[2] = "Ford";
            cars1[3] = "Mazda";

            // Create an array of four elements and add values right away 
            string[] cars2 = new string[4] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements without specifying the size 
            string[] cars3 = new string[] { "Volvo", "BMW", "Ford", "Mazda" };

            // Create an array of four elements, omitting the new keyword, and without specifying the size
            string[] cars4 = { "Volvo", "BMW", "Ford", "Mazda" };

            int[] myNumbers = { 5, 1, 8, 9 };
            Console.WriteLine(myNumbers.Max());  // returns the largest value
            Console.WriteLine(myNumbers.Min());  // returns the smallest value
            Console.WriteLine(myNumbers.Sum());  // returns the sum of elements

            int[,] numbers = { { 1, 4, 2 }, { 3, 6, 8 } };

            for (int i = 0; i < numbers.GetLength(0); i++)
            {
                for (int j = 0; j < numbers.GetLength(1); j++)
                {
                    Console.WriteLine(numbers[i, j]);
                }
            }

            PrintHello();
            PrintRandom(defaultString: "Nguyen Cong", message: "Trinh Do");
            Console.WriteLine(Sum(5, 5));


            Car myCar = new Car(color:"silver", model:"Bentley Bentayga", year:2025, maxSpeed:300);
            Console.WriteLine(myCar.GetColor());
            Console.WriteLine(myCar.GetMaxSpeed());
            myCar.PrintProCar();
        }

    }
    
}

