using System;
namespace Factory{
    abstract class HiringManager  //Creator
    {
        abstract protected IInterviewer MakeInterviewer();
        public void TakeInterview(){
            var interviewer=this.MakeInterviewer();
            interviewer.AskQuestions();
        }

    
    }

    class DevelopmentManager : HiringManager
    {
        protected override IInterviewer MakeInterviewer()
        {
            return new Developer();
        }
    }

    class MarketingManager : HiringManager
    {
       
        protected override IInterviewer MakeInterviewer()
        {
            return new CommunityExecutive();
        }
    }

    public interface IInterviewer  //IProduct
    {
        void AskQuestions();
    }

 
    class Developer : IInterviewer  //Concrete Product
    {
        public void AskQuestions(){
            Console.WriteLine("Asking about design patterns!");
        }
    
    }

    class CommunityExecutive : IInterviewer  //Concrete Product
    {
        public void AskQuestions(){
            Console.WriteLine("Asking about community building!");
        }
    }
}