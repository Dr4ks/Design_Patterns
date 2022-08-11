using System;
namespace Facade{
    class Program{
        public static void Main(string[] args){
            var computer = new ComputerFacade(new Computer());
            computer.TurnOn(); // Ouch! Beep beep! Loading.. Ready to be used!
            Console.WriteLine();
            computer.TurnOff();  // Bup bup buzzz! Haah! Zzzzz
        }
    }    
}