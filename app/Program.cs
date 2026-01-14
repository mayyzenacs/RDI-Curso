using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var numeros = new List<int>{};
        numeros.Add(10);
        numeros.Add(20);
        numeros.Add(30);

        foreach (var item in numeros)
        {
            Console.WriteLine(item);
        }

        numeros[1] = 50;
        int mudo = numeros.IndexOf(10);
        numeros[mudo] = 5;
        numeros.Remove(30);

        foreach (var i in numeros)
        {
            Console.WriteLine(i);
        }

        Dictionary<string, string> capitais = new Dictionary<string, string>();
        
    }
}