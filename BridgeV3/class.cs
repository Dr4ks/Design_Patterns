using System;
namespace BridgeV3{
    public interface IMRScanner{ //Implementation
        public void StartScan();
        public void StopScan();
        public void StartPostProc();
        public void StartRecon();


    }
    public class MRScannerSimulator:IMRScanner{ //Concrete implementor
        public void StartScan(){
            Console.WriteLine("Scanning was started by MRScannerSimulator");
        }

        public void StopScan(){
            Console.WriteLine("Scanning was stopped by MRScannerSimulator");
        }

        public void StartPostProc(){
            Console.WriteLine("Posting products was started by MRScannerSimulator");
        }

        public void StartRecon(){
            Console.WriteLine("Reconniascence was started by MRScannerSimulator");
        }

    }

    public class MRBayScanner:IMRScanner{ //Concrete implementor
        public void StartScan(){
            Console.WriteLine("Scanning was started by MRBayScanner");
        }

        public void StopScan(){
            Console.WriteLine("Scanning was stopped by MRBayScanner");
        }

        public void StartPostProc(){
            Console.WriteLine("Posting products was started by MRBayScanner");
        }

        public void StartRecon(){
            Console.WriteLine("Reconniascence was started by MRBayScanner");
        }

    }

    public interface IMRConsole{
        public void PerformScan();
        public void CheckScanStatus();
        public void PerformPostProcessing();
    }


    public abstract class BaseMRConsole:IMRConsole{  //Abstraction
        protected IMRScanner imrscanner;

        public abstract void PerformScan();
        public abstract void CheckScanStatus();
        public abstract void PerformPostProcessing();
    }

    public class IngeniaConsole:BaseMRConsole{  //Refined Abstraction

        public IngeniaConsole(IMRScanner imrscanner){
            this.imrscanner=imrscanner;
        }
        public override void PerformScan()
        {
            Console.WriteLine("Scan was performed by IngeniaConsole");
        }
        public override void CheckScanStatus()
        {
            Console.WriteLine("Scan's status was checked by IngeniaConsole");
        }
        public override void PerformPostProcessing()
        {
            Console.WriteLine("Posting products was performed by IngeniaConsole");
        }
    }

    public class ProdivaMRConsole:BaseMRConsole{  //Refined Abstraction

        public ProdivaMRConsole(IMRScanner imrscanner){
            this.imrscanner=imrscanner;
        }
        public override void PerformScan()
        {
            Console.WriteLine("Scan was performed by ProdivaMRConsole");
        }
        public override void CheckScanStatus()
        {
            Console.WriteLine("Scan's status was checked by ProdivaMRConsole");
        }
        public override void PerformPostProcessing()
        {
            Console.WriteLine("Posting products was performed by ProdivaMRConsole");
        }
    }
}