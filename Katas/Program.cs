using System;

namespace Katas
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            //pieTime findPie = new pieTime();
            //findPie.pieUp(4, 6);

            Palindrome findPalindome = new Palindrome();
            findPalindome.Palin();

            stringSpace findSpace = new stringSpace();
            findSpace.stringSpaced();

            Prime findPrime = new Prime();
            findPrime.primeNumber();
        }
    }
}
