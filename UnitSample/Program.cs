using System;

namespace UnitSample
{
    public class Program
    {
         static void Main()
        {
            var qe = new QuadEqua(1, 1, 1);
            Console.WriteLine(qe.Root1);
            Console.WriteLine(qe.Root2);
        }
    }
}