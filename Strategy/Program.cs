using System;
namespace Strategy{
    class Program{
        public static void Main(string[] args){
            var unSortedList = new List<int> { 1, 10, 2, 16, 19 };

            var sorter = new Sorter(new BubbleSortStrategy());
            Console.WriteLine(sorter.SetNextStrategy(unSortedList)); // // Output : Sorting using Bubble Sort !

            sorter = new Sorter(new QuickSortStrategy());
            Console.WriteLine(sorter.SetNextStrategy(unSortedList)); // // Output : Sorting using Quick Sort !
        }
    }    
}