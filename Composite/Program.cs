using System;
namespace Composite{
    class Program
    {
        static void Main(string[] args)
        {
            Game_Laptop laptop=new Camera();
            Game_Laptop laptop2=new Motherboard();
            laptop2.Add(new Camera());
            laptop2.Add(new Ram8gb());

            var result=laptop.Get_Extensions();
            var result2=laptop2.Get_Extensions();

            Console.WriteLine(result);
            Console.WriteLine(result2);
        }
    }
}