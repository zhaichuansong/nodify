using Emgu.CV;

namespace Nodify.Opencv.ViewModels;

public class ThresholdNodeViewModel : BaseNodeViewModel
{
    public ThresholdNodeViewModel()
    {
        Inputs.Add(new ConnectorViewModel(this, "Input", true));
        Outputs.Add(new ConnectorViewModel(this, "Output", false));
    }

    public override Mat Process(Mat input)
    {
        Mat output = new Mat();
        CvInvoke.Threshold(input, output, 127, 255, Emgu.CV.CvEnum.ThresholdType.Binary);
        return output;
    }
}