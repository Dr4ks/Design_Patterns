using System;
namespace CompositeV3{
    class Program{
        public static void Main(string[] args){
            ILogger consoleLogger = new ConsoleLogger();
            ILogger dbLogger = new DbLogger();
            ILogger fileLogger = new FileLogger();
            

            BroadcastLogger broadcastLogger = new BroadcastLogger();

            broadcastLogger.AddLogger(consoleLogger);
            broadcastLogger.AddLogger(dbLogger);
            broadcastLogger.AddLogger(fileLogger);
            broadcastLogger.WriteLog();

            BiController biController = new BiController(broadcastLogger);
            biController.Interact("Sending messages to Console, DB and File simultaneously");
        }
    }
}