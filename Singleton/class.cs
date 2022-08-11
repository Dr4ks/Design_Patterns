using System;
namespace Singleton{
    public sealed class Calculator{
        public int result;

        private Calculator() { }
        private static Calculator _instance=new Calculator();

        public static Calculator Init()
        {
            if (_instance == null)
            {
                _instance = new Calculator();
            }
            return _instance;
        }


        public Calculator Add(int number){  //Method Chaining that's why 'return this' was used
            _instance.result+=number;
            return this;
        }
        public Calculator Subtract(int number){  //Method Chaining that's why 'return this' was used
            _instance.result-=number;
            return this;
        }
        public Calculator Multiply(int number){  //Method Chaining that's why 'return this' was used
            _instance.result*=number;
            return this;
            
        }
        public Calculator Divide(int number){  //Method Chaining that's why 'return this' was used
            _instance.result/=number;
            return this;  
            
        }

        public int GetResult(){
            return this.result;
        }
    }
}