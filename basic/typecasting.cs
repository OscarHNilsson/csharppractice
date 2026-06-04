using System;

class Typecasting
{
    static void Main()
    {
        //we're changing the type of a variable. this is the implicit way
        int x = 10;

        double y = x;

        Console.WriteLine("Implicit typcasting check: {0}", y);


        //we cant do it for things that wouldn't make sense, like an int to a double
        //so the following will throw errors
        int a = 10;

        double b = 9.1;
        
        //a = b;


        //we can also do it the explicit way by using casting operators
        double i = 4.2;

        int j = (int)i;
        Console.WriteLine("Explicit typecasting check: {0}", j);


        Console.WriteLine("This is written as a string: {0}", Convert.ToString(j));
    }
}