using System;
namespace StrategyV2{
    class Program{
        public static void Main(string[] args){
            StrategyContext quickContext = new StrategyContext(new FasterStrategy());
            quickContext.PerformOperation();

            StrategyContext memoryOptimizedContext = new StrategyContext(new MemoryEfficientStrategy());
            memoryOptimizedContext.PerformOperation();

            StrategyContext bruteForceContext = new StrategyContext(new BruteForceStrategy());
            bruteForceContext.PerformOperation();;
        }
    }
}