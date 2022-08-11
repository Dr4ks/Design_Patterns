using System;
namespace FactoryV2{
    public interface IDbTable{ //Product
        public int numofcols{get;set;}
        public int numofrows{get;set;}

        public void PerformTask();


    }
    public class OracleDbTable:IDbTable{  //Concrete Product
        public int numofcols{get;set;}
        public int numofrows{get;set;}

        public OracleDbTable(int row,int col){
            this.numofcols=col;
            this.numofrows=row;
        }

        public void PerformTask(){
            Console.WriteLine("Task was performed by OracleDB");
        }
    }

    public abstract class TableProvider{  //Creator
        public abstract IDbTable CreateTable(int row,int col);
    }
    public class DBTableCreator:TableProvider{ //Concrete Creator
        public override IDbTable CreateTable(int row, int col)
        {
            return new OracleDbTable(row,col);
        }
    }
}