using System;
namespace DecoratorV2{
    public interface IScanImage{ //Component
        public void RenderImage();
    }
    public class MRScanImage:IScanImage{ //Concrete Component
        public void RenderImage(){
            Console.WriteLine("Performing rending of MR Image");
        }
    }
    public abstract class MRImageAnnotator:IScanImage{ //Decorator
        protected IScanImage image;

        public MRImageAnnotator(IScanImage image){
            this.image=image;
        }

        public abstract void RenderImage();

    }
    public class TextAnnotator:MRImageAnnotator{  //Concrete Decorator

        public TextAnnotator(IScanImage image):base(image)
        {
        }
        public void AddText(){
            Console.WriteLine("Text was added");
        }
        public override void RenderImage()
        {
            Console.WriteLine("Image was rendered by TextAnnotator");
        }
    }
    public class GeometryAnnotator:MRImageAnnotator{
        public GeometryAnnotator(IScanImage image):base(image)
        {
        }
        public void AddGeometry(){
            Console.WriteLine("Geometry was added");

        }
        public override void RenderImage()
        {
            Console.WriteLine("Image was rendered by GeometryAnnotator");
        }
    }
}