using System;
namespace TemplateV3{
    class Program{
        public static void Main(string[] args){
            DatabaseAccessor dbAccessor = new MSSQLDbAccessor();
            string query = "SELECT * from Table";
            dbAccessor.Run(query);
        }
    }   
}