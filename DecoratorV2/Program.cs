using System;
namespace DecoratorV2{
    class Program{
        public static void Main(string[] args){
            IScanImage scanImage = new MRScanImage();

            scanImage=new TextAnnotator(scanImage);
            scanImage=new GeometryAnnotator(scanImage);

            scanImage.RenderImage();

        }
    }
}