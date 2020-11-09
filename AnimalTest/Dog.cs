using System;
namespace AnimalTest
{
    public class Dog : Animal
    {
        public override void Eat()
        {
            Console.WriteLine("The dog is eating");
        }
    }
}