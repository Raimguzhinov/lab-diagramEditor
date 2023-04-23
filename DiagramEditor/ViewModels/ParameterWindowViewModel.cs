using DiagramEditor.Models.Grids;
using ReactiveUI;

namespace DiagramEditor.ViewModels
{
    public class ParameterWindowViewModel : ViewModelBase
    {
        private GridStrings strings;

        public ParameterWindowViewModel()
        {
            strings = new GridStrings();
        }

        public GridStrings Strings
        {
            get => strings;
            set => this.RaiseAndSetIfChanged(ref strings, value);
        }
    }
}
