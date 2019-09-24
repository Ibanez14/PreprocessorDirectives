#define TESTING

using System;

namespace TestingPreProcessorDirectives
{
   
    class Program
    {
        static void Main(string[] args)
        {

        }


        private static void TestErrorDirective()
        {

#error Deprecated code

#if TESTING
#error Under testing mode
#endif


#if RELEASE
#error Under release mode
#endif

        }


        private static void TestWarningMode()
        {


#warning Hello from warning


#if TESTING
#warning Testing mode is going on
#endif


#if RELEASE
#warning Release mode
#endif


        }

        public static void TestUndefinedPreProcessor()
        {

#if TESTING
            Console.WriteLine("Testing mode");
#endif
        }

        public static void TestMainDirectives()
        {

#if TESTING
            Console.WriteLine("Some Kind of Work");
#endif


            // Deafult definitions

#if NETCOREAPP
            Console.WriteLine("Is .NET Core");
#endif


#if NETCOREAPP2_2
            global::System.Console.WriteLine();
#endif


#if NETCOREAPP2_1
            global::System.Console.WriteLine();
#endif


#if NETSTANDART
            Console.WriteLine();
#endif




#if (DEBUG && !MYTEST)
            Console.WriteLine("DEBUG is defined");
#elif (!DEBUG && MYTEST)
        Console.WriteLine("MYTEST is defined");
#elif (DEBUG && MYTEST)
        Console.WriteLine("DEBUG and MYTEST are defined");  
#else
        Console.WriteLine("DEBUG and MYTEST are not defined");
#endif



#if DEBUG
            global::System.Console.WriteLine();
#else

#endif //  YOU MUST SPECIFY ENDIF directive




        }
    }


    // Is for generating an example warning
    [CLSCompliant(false)]
    public class Test
    {

    }
}
