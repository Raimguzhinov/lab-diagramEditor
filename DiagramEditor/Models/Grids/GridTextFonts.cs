using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEditor.Models.Grids
{
    public class GridTextFonts : AbstractNotifyPropertyChanged
    {
        public bool IsMainParametersAbstract { get; set; }
        public bool IsMainParametersStatic { get; set; }
        public bool IsAttributesAbstract { get; set; }
        public bool IsAttributesStatic { get; set; }
        public bool IsOperationsAbstract { get; set; }
        public bool IsOperationsStatic { get; set; }
    }
}
