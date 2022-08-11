using System;
namespace FactoryV2{
    class Program{
        public static void Main(string[] args){
            TableProvider tableProvider = new DBTableCreator();
            IDbTable table = tableProvider.CreateTable(4, 4);
            Console.WriteLine($"Table is created of type : {table.GetType().Name}");
        }
    }

}