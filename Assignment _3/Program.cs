using System;
using System.Collections.Generic;
using System.Linq;

class MainClass
{
    public static void Main(string[] args)
    {
        
        List<int> NoPrime = new List<int>();
        List<int> Prime = new List<int>();

        Console.WriteLine("write a number");
        int number = int.Parse(Console.ReadLine());

        for (int x = 2; x <= number; x++)
        {
            for (int y = x * 2; y <= number; y = y + x)
            {

                if (!NoPrime.Contains(y))
                {
                    NoPrime.Add(y);
                }
            }      
        }
        for (int z = 2; z <= number; z++)
        {
            if (!NoPrime.Contains(z))
            {
                Prime.Add(z);
            }
        }

        List<int> uniqueListInt = Prime.Distinct().ToList();

        foreach (int primes in uniqueListInt)
        {
            System.Console.Write("{0} ", primes);
        }
        Console.ReadLine();
    }
}