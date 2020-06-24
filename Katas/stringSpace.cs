using System;
namespace Katas
{
    public class stringSpace
    {
        public void stringSpaced()
        {
            string hello = "hello world";
            Console.WriteLine(Char.IsWhiteSpace(hello, 5));
        }
    }
}
