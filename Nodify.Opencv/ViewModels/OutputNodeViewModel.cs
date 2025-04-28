using Emgu.CV;

namespace Nodify.Opencv.ViewModels;

public class OutputNodeViewModel : BaseNodeViewModel
{
    public OutputNodeViewModel()
    {
        Inputs.Add(new ConnectorViewModel(this, "Input", true));
    }
    public Mat? Result { get; set; }
    public override Mat Process(Mat input)
    {
        Result = input.Clone();
        return Result;
    }
}