using System;
using System.ComponentModel.Design.Serialization;

class Loops
{
    static void Main()
    {
        //loops do things repeatedly, either infinitely or until a condition is met.
        int i = 0;
        while (i < 5)
        {
            Console.WriteLine(i);
            i++;
        }

        for (int j = 5; j < 11; j++)
        {
            Console.WriteLine(j);
        }

        int k = 11;
        do
        {
            Console.WriteLine(k);
            k++;
        } while (k < 16);
    }
}