using System;
namespace ProxyV3{
    public interface IScanManager{ //Service Interface
        public void GetScanImages();

    }

    public class ScanManagerService:IScanManager{ //Service
        public void GetScanImages(){

        }
    }
    public class ScanManagerProxy:IScanManager{ //Proxy
        private ScanManagerService service;
        public void GetScanImages(){
            if(this.CheckAccess()){
                Console.WriteLine("Images were scanned by using Proxy");
            }
        }

        private bool CheckAccess(){
            return true;  //if you wanna add other rules to make proxy
        }
    }
}