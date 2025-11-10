using System;

namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // string fullName = "Nguyen Cong Trinh Do";
            string firtName = Console.ReadLine();
            string lastName = Console.ReadLine();
            string fullName = firtName + " " + lastName;
            Console.WriteLine("Enter your age:");
            int age = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Your age is: " + age);
            Console.WriteLine("Hello, " + fullName);
            const int myGradeInt = 10;
            // const double myGradeDouble = myGradeInt;
            Console.WriteLine("My grade is: " + Convert.ToDouble(myGradeInt));
        }
    }
}

