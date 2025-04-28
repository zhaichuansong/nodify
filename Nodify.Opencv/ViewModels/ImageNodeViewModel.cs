using Emgu.CV;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodify.Opencv.ViewModels;

internal class ImageNodeViewModel : BaseNodeViewModel
{
   
    public override Mat Process(Mat input)
    {
        return _image.Clone();
    }
    private Mat _image;
    public ImageNodeViewModel(string imagePath)
    {
        _image = CvInvoke.Imread(imagePath);
        Title="图像输入";
        Outputs.Add(new ConnectorViewModel(this,  "Output", false));
    }
}
