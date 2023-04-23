using Avalonia;
using System;

namespace DiagramEditor.Models
{
    public class ChangeStartPointEventArgs : EventArgs
    {
        public Point NewStartPoint { get; set; }
        public Point OldStartPoint { get; set; }

    }
}
