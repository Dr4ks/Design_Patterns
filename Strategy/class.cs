using System;
namespace Strategy{
     class Sorter //Context
    {
      
        private ISortStrategy _strategy;



        public Sorter(ISortStrategy strategy)
        {
            this._strategy = strategy;
        }

        public string SetNextStrategy(List<int> list){
            return _strategy.Sort(list);
        }

    
    }

    
    public interface ISortStrategy //IStrategy
    {
        string Sort(List<int> list);
    }

   
    class BubbleSortStrategy : ISortStrategy  //Concrete Strategy
    {
        public string Sort(List<int> list)
        {
            return "Sorting using Bubble Sort !";
            
        }
    }

    class QuickSortStrategy : ISortStrategy
    {
        public string Sort(List<int> list)
        {
            return "Sorting using Quick Sort !";

        }
    }
}