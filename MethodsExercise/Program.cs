using System;

class Program
{
    static void Main(string[] args)
    {
        
        Console.WriteLine("What is your name?");
        string name = Console.ReadLine();

        
        Console.WriteLine("What is your favorite color?");
        string color = Console.ReadLine();

        
        Console.WriteLine("What is your favorite animal?");
        string animal = Console.ReadLine();

      
        Console.WriteLine("What is your favorite band?");
        string band = Console.ReadLine();

       
        Console.WriteLine($"Once upon a time, there was a person named {name}.");
        Console.WriteLine($"{name} loved the color {color} and dreamed of a world painted in it.");
        Console.WriteLine($"Their spirit animal was the majestic {animal}, known for its wisdom and grace.");
        Console.WriteLine($"Whenever {name} needed inspiration, they listened to the tunes of {band}, their favorite band.");
        Console.WriteLine($"And they lived happily ever after, surrounded by {color}, with their loyal {animal} companion and the melodies of {band}.");

        
        Console.ReadLine();
    }
}