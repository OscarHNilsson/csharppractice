using System;

class Decisions
{
    static void Main()
    {
        //here we're trying decisions

        bool x = true;

        if (x)
        {
            Console.WriteLine("The boolean is true.");
        }
        else
        {
            Console.WriteLine("The boolean is false");
        }

        //we can also do several if statements in one

        string striing = "Hello";

        if (striing == "Hi")
        {
            Console.WriteLine("Hi there");
        }
        else if (striing == "Hello")
        {
            Console.WriteLine("Hello there");
            if (x)
            {
                Console.WriteLine("This shit is nested");
            }
        }
        else if (striing == "Wassup")
        {
            Console.WriteLine("Cool guy");
        }
        else
        {
            Console.WriteLine("Goodbye");
        }


        //you can do long if ladders cleaner by using switch statements

        int i = 10;
        int j = 20;
        switch (i)
        {
            case 5:
                Console.WriteLine("Case 5");
                break;
            case 10:
                Console.WriteLine("Case 10");
                switch (j)
                {
                    case 10:
                        Console.WriteLine("Case is 10 and 10");
                        break;
                    case 20:
                        Console.WriteLine("Case is 10 and 20");
                        break;                
                }
                break;
            case 20:
                Console.WriteLine("Case 20");
                break;
        }
        
        
    }
}