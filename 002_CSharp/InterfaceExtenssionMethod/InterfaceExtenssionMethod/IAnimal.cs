using System;

namespace InterfaceExtenssionMethod
{
    public interface IAnimal
    {
        string RoarSound { get; }
    }

    public class Dog : IAnimal
    {
        public string RoarSound => "わんわん";
    }

    public class Cat : IAnimal
    {
        public string RoarSound => "にゃーにゃー";
    }

    public static class AnimalExtenssionMethod
    {
        public static void Roar(this IAnimal animal)
        {
            Console.WriteLine(animal.RoarSound);
        }
    }
}