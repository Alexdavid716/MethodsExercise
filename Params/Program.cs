using System;

class Program
{
    static void Main(string[] args)
    {
       
        Console.WriteLine(Sum(2, 4));               
        Console.WriteLine(Sum(2, 4, 6));            
        Console.WriteLine(Sum(1, 1, 1, 1, 1));      
        Console.WriteLine(Multiply(10, 2));         
    }

   
    static int Sum(params int[] numbers)
    {
        int result = 0;
        foreach (int num in numbers)
        {
            result += num;
        }
        return result;
    }


    static int Multiply(int a, int b)
    {
        return a * b;
    }
}