using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NetFive._8WarningWave5
{
    public static class StaticClass
    {
        public static void Thing() { }
    }

    public class _8WarningWave5
    {
        //WARNING 1: cannot use a static type in 'is' or 'as'
        //The is and as expressions always return false for a static type because you can't create instances of a static type
        public void M(object o)
        {
            if (o is StaticClass) // WARNING 1: cannot use a static type in 'is' or 'as'
            {
                Console.WriteLine("Can't happen");
            }
            else
            {
                Console.WriteLine("o is not an instance of a static class");
            }
        }

        //WARNING 2: CS8073: The result of the expression is always 'false'
        //The == and != operators always return false (or true) when comparing an instance of a struct type to null.
        void M2(S s)
        {
            if (s == null) { } // CS8073: The result of the expression is always 'false'
            if (s != null) { } // CS8073: The result of the expression is always 'true'
        }

        //WARNING 3: Operator 'from' can't be used here due to precedence. Use parentheses to disambiguate. 
        //The expression binds incorrectly because of the precedence of the operators.
        void Warning3()
        {
            //bool b = true;
            //var source = new Src();
            //b = true;
            //source = new Src();
            //var a = b && from c in source select c; //WARNING 3: Operator 'from' can't be used here due to precedence. Use parentheses to disambiguate. 
            //Console.WriteLine(a);

            //var indexes = new Src2();
            //int[] array = { 1, 2, 3, 4, 5, 6, 7 };
            //var range = array[0..from c in indexes select c]; //WARNING 3: Operator 'from' can't be used here due to precedence. Use parentheses to disambiguate. 
        }

        //WARNING 4: Members must be fully assigned, use of unassigned variable (CS8880, CS8881, CS8882, CS8883, CS8884, CS8885, CS8886, CS8887)
        // We need to use c# 10 to understand this warning.

        //public struct Struct
        //{
        //    private string data = String.Empty;
        //    public Struct() { }
        //}

        //WARNING 5: Method will not be used as an entry point because a synchronous entry point 'method' was found.
        //This warning is generated on all async entry point candidates when you have multiple valid entry points, including one or more synchronous entry point.
        //Because async main was only supported starting with C# 7.1, this warning isn't generated for projects targeting a previous version.

        //public static void Main()
        //{
        //    RunProgram();
        //}

        //// CS8892
        //public static async Task Main(string[] args)
        //{
        //    await RunProgramAsync();
        //}


        //WARNING 6: Static types can't be used as parameters
        //Members of an interface can't declare parameters whose type is a static class. 

        //WARNING 7: static types can't be used as return types
        //Members of an interface can't declare a return type that is a static class. 

        public static class Utilities
        {
            // elided
        }

        public interface IUtility
        {
            // CS8897
            public void SetUtility(Utilities u); //WARNING 6: Static types can't be used as parameters

            // CS8898
            public Utilities GetUtility(); //WARNING 7: static types can't be used as return types
        }
    }

    // **** Related Warning 4
    //public struct Struct
    //{
    //    private string data = String.Empty;
    //    public Struct() { }
    //}

    // **** Related Warning 4

    //public struct DefiniteAssignmentWarnings
    //{
    //    // CS8880
    //    public Struct Property { get; }
    //    // CS8881
    //    private Struct field;

    //    // CS8882
    //    public void Method(out Struct s)
    //    {

    //    }

    //    public DefiniteAssignmentWarnings(int dummy)
    //    {
    //        // CS8883
    //        Struct v2 = Property;
    //        // CS8884
    //        Struct v3 = field;
    //        // CS8885:
    //        DefiniteAssignmentWarnings p2 = this;
    //    }

    //    public static void Method2(out Struct s1)
    //    {
    //        // CS8886
    //        var s2 = s1;
    //        s1 = default;
    //    }

    //    public static void UseLocalStruct()
    //    {
    //        Struct r1;
    //        var r2 = r1;
    //    }
    //}


    struct S
    {
        public static bool operator ==(S s1, S s2) => s1.Equals(s2);
        public static bool operator !=(S s1, S s2) => !s1.Equals(s2);
        public override bool Equals(object? other)
        {
            // Implementation elided
            return false;
        }
        public override int GetHashCode() => 0;

        // Other details elided...
    }   

}
