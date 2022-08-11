using System;
namespace AdapterV2{
    public interface IProcessor{ //Client Interface
        public void Request();
    }

    public class LegacyProcessor{ //Service
        public void RequestLegacy(){
            Console.WriteLine("Request Completed");
        }
    }
    public class ProcessorAdapter:IProcessor{  //Adapter
        private LegacyProcessor legacyProcessor=new LegacyProcessor();
        public void Request(){
            this.legacyProcessor.RequestLegacy();
        }
    }
}