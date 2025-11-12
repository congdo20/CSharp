using System;

namespace MyApp
{
    class Car
    {
        private string model = "BMW i8";
        private string color = "black";
        private int maxSpeed = 200;
        private int year = 2025;

        public Car() { }

        public Car(string model, string color, int maxSpeed, int year)
        {
            this.model = model;
            this.color = color;
            this.maxSpeed = maxSpeed;
            this.year = year;
        }

        public string GetModel()
        {
            return model;
        }

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetColor()
        {
            return color;
        }

        public void SetColor(string color)
        {
            this.color = color;
        }

        public int GetMaxSpeed()
        {
            return maxSpeed;
        }

        public void SetMaxSpeed(int maxSpeed)
        {
            this.maxSpeed = maxSpeed;
        }

        public int GetYear()
        {
            return year;
        }

        public void SetYear(int year)
        {
            this.year = year;
        }

        public void PrintProCar()
        {
            Console.WriteLine("My car " + model + " has " + color + " color, production in " + year + ", this max speed is " + maxSpeed);
        }
    }
}