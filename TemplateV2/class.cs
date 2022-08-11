using System;
namespace TemplateV2{
    abstract class Builder
    {
        public void Build(){
            this.RunningTests();
            this.LintingCode();
            this.AssemblingBuild();
            this.DeployingBuildToServer();
        }
        

 
        protected abstract void RunningTests();

        protected abstract void LintingCode();
        
        protected abstract void AssemblingBuild();

        protected abstract void DeployingBuildToServer();

    }

  
    class AndroidBuilder : Builder
    {
        protected override void RunningTests(){
            Console.WriteLine("Running android tests");
        }

        protected override void LintingCode(){
            Console.WriteLine("Linting the android code");
        }
        
        protected override void AssemblingBuild(){
            Console.WriteLine("Assembling the android build");
        }

        protected override void DeployingBuildToServer(){
            Console.WriteLine("Deploying android build to server");
        }
    }
    class IosBuilder : Builder
    {
        protected override void RunningTests(){
            Console.WriteLine("Running ios tests");
        }

        protected override void LintingCode(){
            Console.WriteLine("Linting the ios code");
        }
        
        protected override void AssemblingBuild(){
            Console.WriteLine("Assembling the ios build");
        }

        protected override void DeployingBuildToServer(){
            Console.WriteLine("Deploying ios build to server");
        }
    }
}