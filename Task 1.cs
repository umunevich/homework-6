using System;

namespace ConsoleApp1
{
    class Car
    {
        private string name;
        private double max_speed;  //km per hour

        public void SetCarName(string name)
        {
            this.name = name;
        }
        public void SetCarMaxSpeed(double max_speed)
        {
            this.max_speed = max_speed;
        }
        public string GetCarName()
        {
            return name;
        }
        public double GetCarMaxSpeed()
        {
            return max_speed;
        }
        public Car(string name, double max_speed)
        {
            this.name=name;
            this.max_speed=max_speed;
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public double MaxSpeed
        {
            get { return max_speed; }
            set { max_speed = value; }
        }

    }
    internal class Program
    {
        static void Main(string[] args)
        {
            Car car1 = new Car("Porsche", 167.3);
            Car car2 = new Car("McLauren", 204.5);

            if (car1.GetCarMaxSpeed() > car2.GetCarMaxSpeed())
            {
                Console.WriteLine($"{car1.GetCarName()} is faster then {car2.GetCarName()} and has top speed {car1.GetCarMaxSpeed()} km/h");
            }
            else
            {
                Console.WriteLine($"{car2.GetCarName()} is faster then {car1.GetCarName()} and has top speed {car2.GetCarMaxSpeed()} km/h");
            }

            Console.ReadKey(false);
        }
    }
}