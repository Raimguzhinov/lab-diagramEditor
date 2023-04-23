using Avalonia.Controls;
using DiagramEditor.ViewModels;

namespace DiagramEditor.Views
{
    public partial class ParameterWindow : Window
    {
        public ParameterWindow()
        {
            InitializeComponent();
            DataContext = new ParameterWindowViewModel();
        }
    }
}
