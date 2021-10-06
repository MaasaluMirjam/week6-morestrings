using System;

namespace AnotherStringToReverse
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm kuvab lauset "hello, world" tagurpidi
            string HelloW = "Hello, World";
            for (int i = HelloW.Length -1; i >= 0; i--)
            {
                Console.Write(HelloW[i]);
            }           
        }
    }
}
