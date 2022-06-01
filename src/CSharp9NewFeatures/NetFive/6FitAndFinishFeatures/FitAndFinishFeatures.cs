using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive._6FitAndFinishFeatures
{
    public class FitAndFinishFeatures
    {
        // **************  1. Target-Typed 'new' Expression **************

        //Before Target-Typed 'new' Expression
        Dictionary<string, List<int>> field = new Dictionary<string, List<int>>() { { "item1", new List<int>() { 1, 2, 3 } } };

        //After Target-Typed 'new' Expression
        Dictionary<string, List<int>> field2 = new() { { "item1", new() { 1, 2, 3 } } };

        //Miscellaneous Warning: Sometimes we don't need to use 'new' or using 'new' is forbidden.
        (int a, int b) t1 = new(1, 2); // "new" is redundant
        (int a, int b) t2 = (1, 2);
        (int a, int b) t3 = (0, 0);
        (int a, int b) t4 = new(); // OK; same as (0, 0)
        Action a1 = new(() => { }); // "new" is redundant
        Action a2 = (() => { }); // //OK        


        //************** 2. Static Anonymous Functions **************

        //Before Static Anonymous Functions

        /*string _text = "{0} is a beautiful country !";

        void PromoteCountry(Func<string, string> func)
        {
            var countries = new List<string> { "Canada", "France", "Japan" };

            foreach (var country in countries)
                Console.WriteLine(func(country));
        }
        PromoteCountry(country => string.Format(this._text, country));*/

        //After Static Anonymous Functions

        /* const string text = "{0} is a beautiful country !"; // text must be declared as const

           void PromoteCountry(Func<string, string> func)
           {
               var countries = new List<string> { "Canada", "France", "Japan" };

               foreach (var country in countries)
                   Console.WriteLine(func(country));
           }

           PromoteCountry(static country => string.Format(text, country)); // text is no */


        // ************** 3.Target-Typed Conditional Expression **************

        //Firstly, we try to use Print method with LONG signature
        //public static void Print(long number)
        //{
        //    Console.WriteLine("{0}: {1}", number.GetType(), number);
        //}

        //Secondly, we change method signature using short.
        public static void Print(short number)
        {
            Console.WriteLine("{0}: {1}", number.GetType(), number); //CS1503	Argument 1: cannot convert from 'int' to 'short'
        }

    }
}
