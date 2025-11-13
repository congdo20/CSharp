using System;
using System.Runtime.InteropServices.Marshalling;

namespace MyApp
{
    abstract class Vehicle // su dung sealed neu khong muon lop khac ke tua
    {        
        public abstract void VehicleRun();
        // private string brand = "BMW";
        public string Brand { get; set; } = "Ducati";

        // public static void Honk()
        public virtual void Honk()
        {
            Console.WriteLine("Tuut, Tuut");
        }


    }

    class Motorbike : Vehicle
    {
        // private string modelName = "Panigale";
        public string ModelName { get; set; } = "Panigale";

        public override void Honk()
        {
            Console.WriteLine("Bru, Bru");
        }

        public override void VehicleRun()
        {
            Console.WriteLine("Viuuuu");
        }
    }
}