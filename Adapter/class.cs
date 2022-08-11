using System;
namespace Adapter{
    interface ILion{  //Client Interface
        public void Roar();

    }

    class AfricaLion:ILion{
        public void Roar(){

        }
    }

    class AsiaLion:ILion{
        public void Roar(){

        }
    }

    class Hunter{
        public void Hunt(ILion lion){

        }
    }

    class WildDog{  //Service
        public void Bark(){

        }
    }

    class WildDogAdapter:ILion{  //Adapter
        private WildDog wildDog;

        public WildDogAdapter(WildDog wildog){
            this.wildDog=wildog;

        }

        public void Roar(){
            wildDog.Bark();
        }
    }
}