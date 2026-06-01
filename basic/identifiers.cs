using System;
/*
There's class, method, object and variable.
Classes, objects and methods use BigBig and variables use smallBig.
No numbers at the start, no spaces, _ is fine
*/
class Identifiers
{
    static void Main(string[] args)
    {
        int a = 10;
        int b = 20;

        int c;

        c = a+b;

        //How does this work?
        Console.WriteLine("The sum of two numbers is: {0}", c);

    }
}
