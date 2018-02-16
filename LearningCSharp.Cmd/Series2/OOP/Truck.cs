using System;
using System.Runtime.CompilerServices;

namespace LearningCSharp.Cmd.Series2.OOP
{
    public class Truck : Vehicle
    {
        public override void AccelerateEngine()
        {

        }

        public override void StopEngine()
        {

        }

        public new void StartEngine(String truckName, [CallerMemberName]String location = "")
        {
            Console.WriteLine($"{truckName} - {location}");
            base.StartEngine();
        }



        public void TruckMethod()
        {

        }

        public static implicit operator Truck(Car c)
        {
            return new Truck();
        }
    }
}