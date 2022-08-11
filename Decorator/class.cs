using System;
namespace Decorator{
    public interface ICoffee  //Component
    {
        
        public string GetDescription();
        public int GetCost();

    }

    public class SimpleCoffee:ICoffee{  //Concrete Component
        public string GetDescription(){
            return "Simple Coffee";
        }
        public int GetCost(){
            return 5;
        }
    }

    public class MilkCoffee:ICoffee{  //Base Decorator
        private ICoffee coffee;

        public MilkCoffee(ICoffee coffee){
            this.coffee=coffee;
        }
        public string GetDescription(){
            return coffee.GetDescription()+",Milk";
        }
        public int GetCost(){
            return coffee.GetCost()+1;
        }
    }
    public class WhipCoffee:ICoffee{  //Base Decorator
        private ICoffee coffee;

        public WhipCoffee(ICoffee coffee){
            this.coffee=coffee;
        }
        public string GetDescription(){
            return coffee.GetDescription()+",Whip";
        }
        public int GetCost(){
            return coffee.GetCost()+1;
        }
    }

    public class VanillaCoffee:ICoffee{  //Base Decorator
        private ICoffee coffee;

        public VanillaCoffee(ICoffee coffee){
            this.coffee=coffee;
        }
        public string GetDescription(){
            return coffee.GetDescription()+",Vanilla";
        }
        public int GetCost(){
            return coffee.GetCost()+1;
        }
    }



    
}