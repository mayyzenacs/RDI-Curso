using System;

class Program
{
    static void Main()
    {
      int a = 1;
      int b = 2;

      for (int i = 1; i < 11; i++)   
        {
            if (i == 1 || i == 2)
            {
                Console.WriteLine($"Tabuada {a}x{i} = {i*a}"); 
            }
            
            if (i == 10)
            {
                Console.WriteLine("---");
                Console.WriteLine($"Tabuada {a}x{i} = {i*a}"); 
            }
        }            
        Console.WriteLine("");
        for (int y = 1; y < 3; y++) 
        {
            Console.WriteLine($"Tabuada {b}x{y} = {y*b}");    
        }
        Console.WriteLine("---");
        for (int z = 10; z != 0; z--) 
        {
            if (z == 10)
            {
                Console.WriteLine($"Tabuada {b}x{z} = {z*b}");
            }
                
        }
    }
}