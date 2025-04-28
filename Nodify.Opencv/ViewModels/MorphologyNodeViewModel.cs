using Emgu.CV;
using System.Drawing;

namespace Nodify.Opencv.ViewModels;

public class MorphologyNodeViewModel : BaseNodeViewModel
{
    public MorphologyNodeViewModel()
    {
        Inputs.Add(new ConnectorViewModel(this, "Input", true));
        Outputs.Add(new ConnectorViewModel(this, "Output", false));
    }

    public override Mat Process(Mat input)
    {
        Mat output = new Mat();
        Mat kernel = CvInvoke.GetStructuringElement(Emgu.CV.CvEnum.ElementShape.Rectangle, new Size(5, 5), new Point(-1, -1));
        CvInvoke.MorphologyEx(input, output, Emgu.CV.CvEnum.MorphOp.Erode, kernel, new Point(-1, -1), 1, Emgu.CV.CvEnum.BorderType.Default, new Emgu.CV.Structure.MCvScalar());
        return output;
    }
}