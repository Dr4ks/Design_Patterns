using System;
namespace SingletonV2{
    public sealed class President  //Singleton
    {

        private President() { }


        private static President _instance=new President();


        public static President GetInstance()
        {
            if (_instance == null)
            {
                _instance = new President();
            }
            return _instance;
        }
    }
    
}