using System;
namespace BridgeV2{
    public class IWebPage  //Abstraction
    {
        protected ITheme _implementation;
        
        public IWebPage(ITheme implementation)
        {
            this._implementation = implementation;
        }
        
        public virtual string GetContent()
        {
            return "Abstract: Base operation with:\n" + 
                _implementation.OperationImplementation();
        }
    }

  
    class About : IWebPage  //Concrete Abstraction
    {
        public About(ITheme implementation) : base(implementation)
        {
        }
        
        public override string GetContent()
        {
            return "About Page in " +
                base._implementation.OperationImplementation();
        }
    }

    class Careers : IWebPage //Concrete Abstraction
    {
        public Careers(ITheme implementation) : base(implementation)
        {
        }
        
        public override string GetContent()
        {
            return "Careers Page in " +
                base._implementation.OperationImplementation();
        }
    }

 
    public interface ITheme //Implementation
    {
        string OperationImplementation();
    }


    class DarkTheme : ITheme  //Concrete Implementation
    {
        public string OperationImplementation()
        {
            return "DarkBlack";
        }
    }

    class LightTheme : ITheme //Concrete Implementation
    {
        public string OperationImplementation()
        {
            return "Off White";
        }
    }
}