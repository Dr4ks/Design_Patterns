using System;
namespace BridgeV3{
    class Program{
        public static void Main(string[] args){
            IMRScanner scanSimulator = new MRScannerSimulator();
            IMRConsole ingeniaConsole = new IngeniaConsole(scanSimulator);

            ingeniaConsole.PerformScan();
            ingeniaConsole.PerformPostProcessing();


            IMRConsole prodivaConsole = new ProdivaMRConsole(scanSimulator);
            prodivaConsole.PerformScan();
            prodivaConsole.PerformPostProcessing();

            IMRScanner mrBayScanner = new MRBayScanner();
            prodivaConsole = new ProdivaMRConsole(mrBayScanner);
            prodivaConsole.PerformScan();
            prodivaConsole.PerformPostProcessing();
        }
    }
}