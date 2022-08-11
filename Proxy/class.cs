using System;
namespace Proxy{
    interface IOrderableMask //Service Interface
    {
        void CreateOrder(Person person);
    }
    

    class Person  
    {
        public string id{get;set;}
        public string location{get;set;}

        public Person(string id,string location){
            this.id=id;
            this.location=location;
        }
    }

    class MaskOrder : IOrderableMask{  //Service
        public void CreateOrder(Person person){
            Console.WriteLine($"Order created for {person.id} in this location=>{person.location}");
        }
    }
    
    class AuthenticatableMaskOrderProxy : IOrderableMask  //Proxy
    {
        private MaskOrder _realSubject;

        public AuthenticatableMaskOrderProxy()
        {
            _realSubject=new MaskOrder(); //Mask Order
        }
        

        public void CreateOrder(Person person)
        {
            if (this.CheckAccess())
            {
                this._realSubject.CreateOrder(person);

            }
        }
        
        public bool CheckAccess()
        {
            return true;
        }
        
    }
}