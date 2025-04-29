using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm;
using System.Windows;

namespace Nodify.Opencv.ViewModels;

public partial class ConnectorViewModel : ObservableObject
{
    [ObservableProperty]
    private string? _title;
    [ObservableProperty]
    private bool _isConnected;
    [ObservableProperty]
    private bool _isInput;
    [ObservableProperty]
    private Point _anchor;
    [ObservableProperty]
    private BaseNodeViewModel _operation = default!;
    public ConnectorViewModel(BaseNodeViewModel node,string title,bool isInput)
    {
        _operation = node;
        _title = title;
        _isInput = isInput;
    }
}