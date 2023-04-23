using ReactiveUI;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using DiagramEditor.Models;
using DiagramEditor.Models.Serializers;
using System.Linq;

namespace DiagramEditor.ViewModels
{
    public class MainWindowViewModel : ViewModelBase
    {
        private ObservableCollection<AbstractElement> shapes = null!;
        private bool isInterface;
        private bool isClass;
        private bool isAssociation;
        private bool isAggregation;
        private bool isDependency;
        private bool isComposition;
        private bool isInheritance;
        private bool isImplementation;
        private bool isMove;
        private bool isResize;
        private bool isDelete;
        public MainWindowViewModel()
        {
            IsMove = true;
            Shapes = new ObservableCollection<AbstractElement>();
        }

        public ObservableCollection<AbstractElement> Shapes
        {
            get => shapes;
            set => this.RaiseAndSetIfChanged(ref shapes, value);
        }
        public bool IsClass
        {
            get => isClass;
            set => this.RaiseAndSetIfChanged(ref isClass, value);
        }
        public bool IsAggregation
        {
            get => isAggregation;
            set => this.RaiseAndSetIfChanged(ref isAggregation, value);
        }
        public bool IsAssociation
        {
            get => isAssociation;
            set => this.RaiseAndSetIfChanged(ref isAssociation, value);
        }
        public bool IsInterface
        {
            get => isInterface;
            set => this.RaiseAndSetIfChanged(ref isInterface, value);
        }
        public bool IsComposition
        {
            get => isComposition;
            set => this.RaiseAndSetIfChanged(ref isComposition, value);
        }
        public bool IsDependency 
        {
            get => isDependency;
            set => this.RaiseAndSetIfChanged(ref isDependency, value);
        }
        public bool IsImplementation
        {
            get => isImplementation; 
            set => this.RaiseAndSetIfChanged(ref isImplementation, value);
        }
        public bool IsResize
        {
            get => isResize;
            set => this.RaiseAndSetIfChanged(ref isResize, value);
        }
        public bool IsInheritance
        {
            get => isInheritance;
            set => this.RaiseAndSetIfChanged(ref isInheritance, value);
        }
        public bool IsDelete
        {
            get => isDelete;
            set => this.RaiseAndSetIfChanged(ref isDelete, value);
        }
        public bool IsMove
        {
            get => isMove;
            set => this.RaiseAndSetIfChanged(ref isMove, value);
        }
        public IEnumerable<ISaverLoaderFactory> SaverLoaderFactoryCollection { get; set; } = null!;

        public void SaveFigures(string path)
        {
            IShapeSaver? figureSaver = SaverLoaderFactoryCollection
                .FirstOrDefault(factory => factory.IsMatch(path))?
                .CreateSaver();
            if (figureSaver != null)
            {
                figureSaver.Save(Shapes, path);
            }
        }
        public void LoadFigures(string path)
        {
            Shapes = null!;
            Shapes = new ObservableCollection<AbstractElement>();


            IShapeLoader? figureLoader = SaverLoaderFactoryCollection
                .FirstOrDefault(factory => factory.IsMatch(path))?
                .CreateLoader();
            if (figureLoader != null)
            {
                Shapes = figureLoader.Load(path);
            }
        }
    }
}
