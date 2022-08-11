using System;
namespace StrategyV2{
    public class StrategyContext{  //Context
        private IStrategy strategy;
        public StrategyContext(IStrategy strategy){
            this.strategy=strategy;
        }
        public void SetStrategy(IStrategy strategy){
            this.strategy=strategy;
        }
        public void PerformOperation(){
            this.strategy.ExecuteStrategy();
        }


    }

    public interface IStrategy{ //Strategy
        public void ExecuteStrategy();
    }

    public class FasterStrategy:IStrategy{
        public void ExecuteStrategy(){
            Console.WriteLine("FasterStrategy was assigned");
        }
    }
    public class MemoryEfficientStrategy:IStrategy{
        public void ExecuteStrategy(){
            Console.WriteLine("MemoryEfficientStrategy was assigned");
        }
    }
    public class BruteForceStrategy:IStrategy{
        public void ExecuteStrategy(){
            Console.WriteLine("BruteForceStrategy was assigned");
        }
    }
}