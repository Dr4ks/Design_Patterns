using System;
namespace ProxyV3{
    class Program{
        public static void Main(string[] args){
            IScanManager scanManager = new ScanManagerProxy(); //Can be initialized using dependency injection
            scanManager.GetScanImages();
        }
    }
}