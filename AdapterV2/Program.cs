using System;
namespace AdapterV2{
    class Program{
        public static void Main(string[] args){
            IProcessor target = new ProcessorAdapter();
            target.Request();
        }
    }   
}