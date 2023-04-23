using DynamicData.Binding;

namespace DiagramEditor.Models
{
    public abstract class AbstractElement : AbstractNotifyPropertyChanged
    {
        protected uint Id;
        private static uint _idGenerator = 0;
        public AbstractElement()
        {
            Id = _idGenerator++;
        }
        public uint ID { get => Id; set => SetAndRaise(ref Id, value); }
    }
}
