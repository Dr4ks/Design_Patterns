using System;
namespace Chain{
    class Program{
        public static void Main(string[] args){
            RotateHandler _rotate = new RotateHandler();
            ScalingHandler _scaling = new ScalingHandler();
            TransformImageHandler _transform = new TransformImageHandler();
            BrightnessHandler _brightness = new BrightnessHandler();

            _rotate.SetNextHandler(_scaling);
            _scaling.SetNextHandler(_transform);
            _transform.SetNextHandler(_brightness);

            _rotate.ProcessImage();
        }
    }
}
