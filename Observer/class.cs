using System;
namespace Observer{

    public class JobPosting{  //Observable
        List<JobSearcher> searchers=new List<JobSearcher>();
        public void Notify(string job){
            foreach(JobSearcher jobSearcher in searchers){
                Console.WriteLine($"Hi {jobSearcher.name}! New job posted: {job} ");
            }
        }

        public void Subscribe(JobSearcher jobSearcher){
            searchers.Add(jobSearcher);
        }
        public void UnSubscribe(JobSearcher jobSearcher){
            searchers.Remove(jobSearcher);
        }
    }

    public class JobSearcher{  //IObserver
        public string name;

        public JobSearcher(string name){
            this.name=name;
        }


    }
}