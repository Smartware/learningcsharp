using System;

namespace LearningCSharp.Cmd.Series2.OOP
{
    public abstract class Vehicle
    {
        public abstract void AccelerateEngine();
        public abstract void StopEngine();

        public virtual void StartEngine()
        {
            Console.WriteLine($"{nameof(Vehicle)} has started");
        }
    }
}