using System;
namespace Chain{
    public abstract class ImageHandler{  //Handler
        protected ImageHandler imageHandler;

        public abstract void ProcessImage();
        public void SetNextHandler(ImageHandler imageHandler){
            this.imageHandler=imageHandler;
        }

    }
    public class TransformImageHandler:ImageHandler{
        public override void ProcessImage()
        {
            Console.WriteLine("Image was transformed");
        }
    }
    public class ScalingHandler:ImageHandler{
        public override void ProcessImage()
        {
            Console.WriteLine("Image was scaled");
        }
    }
    public class RotateHandler:ImageHandler{
        public override void ProcessImage()
        {
            Console.WriteLine("Image was rotated");
        }
    }
    public class BrightnessHandler:ImageHandler{
        public override void ProcessImage()
        {
            Console.WriteLine("Image was brighted");
        }
    }
}