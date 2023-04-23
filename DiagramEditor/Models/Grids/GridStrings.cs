using DynamicData.Binding;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DiagramEditor.Models.Grids
{
    public class GridStrings : AbstractNotifyPropertyChanged
    {
        private GridTextFonts fonts;

        public GridStrings(){
            Fonts = new GridTextFonts();
        }
        public string Attributes { get; set; }
        public string Operations { get; set; }
        public string MainParameters { get; set; }
        public GridTextFonts Fonts
        {
            get => fonts;
            set => SetAndRaise(ref fonts, value);
        }
    }
}
