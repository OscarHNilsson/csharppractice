using System;

namespace KeyWords
{
    class Examples
    {
        //three keywords right off the bat
        static public void Main ()
        {
            //another one
            /*
            int a = 1;
            
            Console.WriteLine("Value is {0}", a);
            */

            //here we're trying to put two keywords for a variable,
            //it does not work

            //double int a = 2;


            MoreKeywords();
        }
       private static void MoreKeywords() 
       {
        //reference keywords store references. 
        //this includes words like class, interface and void.

        //modifier keywords modify declarations, 
        //such as the private before the void in this method.
        //here's another example:

        double b = 10;


        /*
        Statements keywords are instructions, 
        like if, else, while, try, switch, break etc.
        */

        for (int i = 1; i < 10; i++)
            {
                Console.WriteLine("{0}", i);
                if (i == 7) {
                    Console.WriteLine("We got the special number!");
                    break;
                }
            }

        /*
        Method parameters change the behavious of params
        passed to methods. They are:
        params, in, ref, out.
        */

        /*
        Namespace keywords are namespace, using and extern.
        */

        /*
        Operator keywords are used for things like 
        creating objects, getting sizes of objects etc.
        Some examples are as, is , new, sizeof.
        */

        /*
        Conversion keywords are used to convert types. these are:
        explicit, implicit, operator
        */

        /*
        Acess keywords reference instances of objects. these are:
        base, this
        */

        /*
        Literal keywords are used as literal or constant. these are:
        null, default
        */

        //You can use keywords as identifiers if u put @ before them, example:
        int @int = 0;

        /*
        There are also contextual keywords that do
        different things depending on where they are used.
        some examples are await, into, let, select, from, async, on
        */
        } 
    }
}
