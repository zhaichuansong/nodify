using CommunityToolkit.Mvvm.ComponentModel;
using Emgu.CV;
using System.Collections.ObjectModel;
using System.Windows;

namespace Nodify.Opencv.ViewModels;

public abstract partial class BaseNodeViewModel : ObservableObject
{
    public ObservableCollection<ConnectorViewModel> Inputs { get; } = [];
    public ObservableCollection<ConnectorViewModel> Outputs { get; } = [];
    [ObservableProperty]
    private Point _location;
    [ObservableProperty]
    private Size _size;
    [ObservableProperty]
    private  string? _title;
    [ObservableProperty]
    private bool _isSelected;
    public abstract Mat Process(Mat input);
}
