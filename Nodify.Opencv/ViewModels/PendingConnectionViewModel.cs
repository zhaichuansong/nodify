using CommunityToolkit.Mvvm.ComponentModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Nodify.Opencv.ViewModels;

public partial class PendingConnectionViewModel:ObservableObject
{
    [ObservableProperty]
    private ConnectorViewModel _source = default!;
    [ObservableProperty]
    private ConnectorViewModel? _target;
    [ObservableProperty]
    private bool _isVisible;
    [ObservableProperty]
    private System.Windows.Point _targetLocation;
}
