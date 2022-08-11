using System;
namespace CompositeV3{
    public interface ILogger{ //Component
        public void WriteLog();
    } 

    public class BiController{
        private ILogger logger1;

        public BiController(ILogger logger){
            this.logger1=logger;
        }
        public void Interact(string message){
            Console.WriteLine(message);
        }
    }

    public class BroadcastLogger:ILogger{
        protected List<ILogger> loggers=new List<ILogger>();

        public void AddLogger(ILogger logger){
            loggers.Add(logger);
        }
        public void RemoveLogger(ILogger logger){
            loggers.Remove(logger);
        }
        public void WriteLog(){
            foreach(ILogger logger in loggers){
                logger.WriteLog();
            }
        }
    }
    public class FileLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Log was written by FileLogger");
        }
    }
    public class DbLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Log was written by DbLogger");
        }
    }
    public class ConsoleLogger:ILogger{
        public void WriteLog(){
            Console.WriteLine("Log was written by ConsoleLogger");
        }
    }
}