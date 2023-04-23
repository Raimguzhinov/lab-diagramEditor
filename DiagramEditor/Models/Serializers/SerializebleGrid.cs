using DiagramEditor.Models.Grids;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEditor.Models.Serializers
{
    public class SerializebleGrid : SerializebleElement
    {
        public string TypeGrid { get; set; }
        public string StartPoint { get; set; }
        public GridStrings GridText { get; set; }
        public double Height { get; set; }
        public double Width { get; set; }
    }
}
