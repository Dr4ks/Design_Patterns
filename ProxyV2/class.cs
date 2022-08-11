using System;
namespace ProxyV2{
    public interface IDoor //Service Interface
    {
        void Close();
    }
    

    class LabDoor : IDoor  //Service
    {
        public void Close()
        {
            Console.WriteLine("Closing lab door");
        }
        public void Open(){
            Console.WriteLine("Opening lab door");
        }
    }
    
    class SecureDoor : IDoor  //Proxy
    {
        private LabDoor _realSubject;
        
        public SecureDoor(LabDoor realSubject)
        {
            this._realSubject = realSubject;
        }
        
        public void Open(string keyword)
        {
            if (this.CheckAccess(keyword))
            {
                this._realSubject.Open();

            }
            else{
                Console.WriteLine("Big no! It ain't possible.");
            }
        }
        public void Close(){
            _realSubject.Close();
        }
        
        private bool CheckAccess(string keyword)
        {
            if(keyword=="$ecr@t"){
                return true;
            }
            else{
                return false;
            }
        }
    }   
}