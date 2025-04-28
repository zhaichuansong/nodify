using CommunityToolkit.Mvvm.ComponentModel;

namespace Nodify.Opencv.ViewModels;

public partial class ConnectionNodeViewModel : ObservableObject
{
    [ObservableProperty]
    private ConnectorViewModel? _input;

    [ObservableProperty]
    private ConnectorViewModel? _output;
}