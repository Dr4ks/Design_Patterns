using System;
namespace ProxyV2{
    class Program{
        public static void Main(string[] args){
            var door = new SecureDoor(new LabDoor());
            door.Open("invalid"); // Big no! It ain't possible.

            door.Open("$ecr@t"); // Opening lab door
            door.Close(); // Closing lab door
        }
    }   
}