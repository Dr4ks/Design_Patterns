using System;
namespace Template{
    abstract class DataAnalyzerBase //Abstract Class
    {
        public void AnalyzeDataOfLastWeek()  //Template-Method
        {
            this.GetDataOfLastWeek();
            this.AnalyzeData();
            this.Export();
        }

        protected void GetDataOfLastWeek()  //Base Operation  //This function can't be overriden
        {
            Console.WriteLine("Method worked: GetDataOfLastWeek");
        }

        protected void AnalyzeData()  //Base Operation    //This function can't be overriden
        {
            Console.WriteLine("Method worked: AnalyzeData");
        }

        

        protected abstract void Export();
    }


    class XmlDataAnalyzer : DataAnalyzerBase  //Concrete Class
    {
        protected override void Export()
        {
            Console.WriteLine("XML exported.\n");
        }

    }


    class HtmlDataAnalyzer : DataAnalyzerBase  //Concrete Class
    {
        protected override void Export()
        {
            Console.WriteLine("HTML exported.\n");
        }
    }


}