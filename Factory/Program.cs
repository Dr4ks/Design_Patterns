using System;
namespace Factory{
    class Program{
        public static void Main(string[] args){
            var devManager = new DevelopmentManager();
            devManager.TakeInterview(); //Output : Asking about design patterns!

            var marketingManager = new MarketingManager();
            marketingManager.TakeInterview();//Output : Asking about community building!
        }
    }
}