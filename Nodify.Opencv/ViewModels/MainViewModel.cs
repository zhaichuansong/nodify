using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;

namespace Nodify.Opencv.ViewModels;

public partial class MainViewModel : ObservableObject
{
    public MainViewModel()
    {
        Nodes = new ObservableCollection<BaseNodeViewModel>();
        Nodes.Add(new ImageNodeViewModel("D:\\模板.tif") { Location=new System.Windows.Point(50,50)});
        Nodes.Add(new ThresholdNodeViewModel() { Location=new(400,400),Title="阈值分割"});
    }

    public ObservableCollection<ConnectionNodeViewModel> Connections { get; set; } = [];
    public ObservableCollection<BaseNodeViewModel> Nodes { get; set; } = [];
    public PendingConnectionViewModel PendingConnection { get; set; } = new();
    [RelayCommand(CanExecute = "CanStartConnection")]
    private void StartConnection(ConnectorViewModel connectorViewModel)
    {
        
        PendingConnection.IsVisible = true;
       
    }
    private bool CanStartConnection(ConnectorViewModel connectorViewModel)
    {
        return !connectorViewModel.IsConnected && !connectorViewModel.IsInput;
    }
    [RelayCommand(CanExecute = "CanCreateConnection")]
    private void CreateConnection()
    {
        var source = PendingConnection.Source;
        var target = PendingConnection.Target;
        //if (target == null)
        //{
        //    PendingConnection.IsVisible = true;
        //    return;
        //}
        
        var input = source.IsInput ? source : target;
        var output = target.IsInput ? source : target;
        PendingConnection.IsVisible = false;
        input.IsConnected = true;
        output.IsConnected = true;
       
        var connection = new ConnectionNodeViewModel(input, output);
        Connections.Add(connection);
        
    }
    private bool CanCreateConnection()
    {
        var source = PendingConnection.Source;
        var target = PendingConnection.Target;
        return true;
        if (source == null || target == null)
            return true;
        else
            return false;
    }
}