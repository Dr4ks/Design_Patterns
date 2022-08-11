using System;
namespace Observer{
    class Program{
        public static void Main(string[] args){
            //Create Subscribers
            var johnDoe = new JobSearcher("John Doe");
            var janeDoe = new JobSearcher("Jane Doe");

            //Create publisher and attch subscribers
            var jobPostings = new JobPosting();
            jobPostings.Subscribe(johnDoe);
            jobPostings.Subscribe(janeDoe);

            //Add a new job and see if subscribers get notified
            string job="Software Engineer";
            jobPostings.Notify(job);

            //Output
            // Hi John Doe! New job posted: Software Engineer
            // Hi Jane Doe! New job posted: Software Engineer

        }
    }   
}