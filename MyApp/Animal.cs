using System;

namespace MyApp
{
    interface IAnimal
    {
        public string Name { get; set; }
        void AnimalSound();
        // void Run();
    }

    interface AllDog
    {
        void Sound();
    }

    class Dog : IAnimal, AllDog
    {
        public string Name { get; set; } = "Dog";
        public void AnimalSound()
        {
            Console.WriteLine("Bow, bow");
        }
        
        public void Sound()
        {
            Console.WriteLine("");
        }
        // public void Run()
        // {
        //     Console.WriteLine("");
        // }
    }
}