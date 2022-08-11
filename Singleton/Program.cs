using System;
namespace Singleton{
    class Program
    {
        static void Main(string[] args)
        {
            // The client code.
            Calculator c = Calculator.Init();
            var res=c.Add(2).Multiply(5).Subtract(3).GetResult();

            Calculator c2=Calculator.Init();
            res=c2.Add(3).GetResult();

            Console.WriteLine(res);
        }
    }
}