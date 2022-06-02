using System;
using System.Collections.Generic;
using System.Diagnostics;
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

        //string text = "{0} is a beautiful country !";

        //void PromoteCountry(Func<string, string> func)
        //{
        //    var countries = new List<string> { "Canada", "France", "Japan" };

        //    foreach (var country in countries)
        //        Console.WriteLine(func(country));
        //}
        //PromoteCountry(country => string.Format(this.text, country));



        ////After Static Anonymous Functions

        //const string text = "{0} is a beautiful country !"; // text must be declared as const

        //void PromoteCountry(Func<string, string> func)
        //{
        //    var countries = new List<string> { "Canada", "France", "Japan" };

        //    foreach (var country in countries)
        //        Console.WriteLine(func(country));
        //}

        //PromoteCountry(static country => string.Format(text, country)); 


        // ************** 3.Target-Typed Conditional Expression **************

        //Firstly, we try to use Print method with LONG signature
        //public static void Print(long number)
        //{
        //    Console.WriteLine("{0}: {1}", number.GetType(), number);
        //}

        ////Secondly, we change method signature using short.
        //public static void Print(short number)
        //{
        //    Console.WriteLine("{0}: {1}", number.GetType(), number); //CS1503	Argument 1: cannot convert from 'int' to 'short'
        //}


        // ********* 4.CovariantReturnTypes *******
        // Go to CovariantReturnTypes.cs


        // ********* 6. Lambda Discard Parameters
        //Allow discards(_) to be used as parameters of lambdas and anonymous methods.For example:

        //(_, _) => 0
        //(int _, int _) => 0

        //anonymous methods:
        //delegate (int _, int _) { return 0; }

        //var handler = (object _, EventArgs _) => ShowDialog();


        // ********* 7. Attributes on local functions

        static void Main()
        {
            [Conditional("DEBUG")] //This is new feature. We can add attributes into local functions.
            static void DoAction()
            {
                // Perform action

                Console.WriteLine("Performing action");
            }

            DoAction();
        }
    }
}
