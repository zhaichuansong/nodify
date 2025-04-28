using CommunityToolkit.Mvvm.ComponentModel;
using System.Collections.ObjectModel;

namespace Nodify.Opencv.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Nodes = new ObservableCollection<BaseNodeViewModel>();
        Nodes.Add(new ImageNodeViewModel("D:\\模板.tif") { Location=new System.Windows.Point(50,50)});
        Nodes.Add(new ThresholdNodeViewModel() { Location=new(200,200),Title="阈值分割"});
    }

    public ObservableCollection<ConnectionNodeViewModel> Connections { get; set; } = [];
    public ObservableCollection<BaseNodeViewModel> Nodes { get; set; } = [];
}