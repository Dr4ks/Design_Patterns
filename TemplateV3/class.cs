using System;
namespace TemplateV3{
    public abstract class DatabaseAccessor{
        // protected DatabaseAccessor query;
        public void Run(string query){
            this.ConnectToDB();
            this.BuildQuery(query);
            this.ExecuteQuery();
            this.CloseConnection();
        }
        public abstract void ConnectToDB();
        public abstract void BuildQuery(string query);
        public abstract void ExecuteQuery();
        public abstract void CloseConnection();
    }
    public class MSSQLDbAccessor:DatabaseAccessor{
        public override void ConnectToDB()
        {
            Console.WriteLine("Connection to Database started");
        }
        public override void BuildQuery(string query)
        {
            Console.WriteLine($"{query} was being assigned");
        }
        public override void ExecuteQuery()
        {
            Console.WriteLine("Query is being executed");
        }public override void CloseConnection()
        {
            Console.WriteLine("Connection to Database stopped");
        }
        
    }


    
}