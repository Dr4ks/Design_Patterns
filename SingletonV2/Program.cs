using System;
namespace SingletonV2{
    class Program{
        public static void Main(string[] args){
            President a = President.GetInstance();
            President b = President.GetInstance();

            Console.WriteLine(a == b); //Output : true
        }
    }    
}


