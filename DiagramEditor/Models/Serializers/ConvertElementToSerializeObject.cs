using Avalonia;
using DiagramEditor.Models.Grids;
using DiagramEditor.Models.Lines;
using System.Collections.ObjectModel;

namespace DiagramEditor.Models.Serializers
{
    public static class ConvertElementToSerializeObject
    {
        public static ObservableCollection<SerializebleElement> ToSerializer(ObservableCollection<AbstractElement> elements)
        {
            ObservableCollection <SerializebleElement> serializableElements= new ObservableCollection<SerializebleElement>();
            foreach (AbstractElement el in elements)
            {
                if (el is AbstractGrid grid)
                {
                    if (grid is ClassElement) serializableElements.Add(new SerializebleGrid {TypeGrid="ClassElement", GridText = grid.GridText, Height = grid.Height, ID = grid.ID, Width = grid.Width, StartPoint = grid.StartPoint.ToString() });
                    if (grid is InterfaceElement) serializableElements.Add(new SerializebleGrid {TypeGrid= "InterfaceElement", GridText = grid.GridText, Height = grid.Height, ID = grid.ID, Width = grid.Width, StartPoint = grid.StartPoint.ToString() });
                }
                if (el is AbstractLine line)
                {
                    SerializebleLine newElement = new SerializebleLine {Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, EndPoint = line.EndPoint.ToString(), StartPoint = line.StartPoint.ToString(), ID = line.ID, Lenght = line.Lenght, LineCenterX = line.LineCenterX, FirstGridID = line.FirstGrid.ID, SecondGridID = line.SecondGrid.ID };
                    if (line is AggregationLine) newElement.TypeLine = "AggregationLine";
                    if (line is AssociationLine) newElement.TypeLine = "AssociationLine";
                    if (line is CompositionLine) newElement.TypeLine = "CompositionLine";
                    if (line is DependencyLine) newElement.TypeLine = "DependencyLine";
                    if (line is ImplementationLine) newElement.TypeLine = "ImplementationLine";
                    if (line is InheritanceLine) newElement.TypeLine = "InheritanceLine";
                    serializableElements.Add(newElement);
                }
            }
            return serializableElements;
        }
        public static ObservableCollection<AbstractElement> FromSerializer(ObservableCollection<SerializebleElement> elements)
        {
            ObservableCollection<AbstractElement> figures = new ObservableCollection<AbstractElement>();
            foreach(SerializebleElement element in elements)
            {
                if (element is SerializebleGrid grid)
                {
                    if (grid.TypeGrid == "ClassElement") figures.Add(new ClassElement { ID = grid.ID, Height = grid.Height, GridText = grid.GridText, Width = grid.Width, StartPoint = Point.Parse(grid.StartPoint)});
                    if (grid.TypeGrid == "InterfaceElement") figures.Add(new InterfaceElement { ID = grid.ID, Height = grid.Height, GridText = grid.GridText, Width = grid.Width, StartPoint = Point.Parse(grid.StartPoint) });
                }
                if (element is SerializebleLine line)
                {
                    if (line.TypeLine == "AggregationLine")
                    {
                        var newElement = new AggregationLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach(AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);
                    }
                    if (line.TypeLine == "AssociationLine")
                    {
                        var newElement = new AssociationLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);

                    }
                    if (line.TypeLine == "CompositionLine")
                    {
                        var newElement = new CompositionLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);

                    }
                    if (line.TypeLine == "DependencyLine")
                    {
                        var newElement = new DependencyLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);

                    }
                    if (line.TypeLine == "ImplementationLine")
                    {
                        var newElement = new ImplementationLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);

                    }
                    if (line.TypeLine == "InheritanceLine")
                    {
                        var newElement = new InheritanceLine { ID = line.ID, Angle = line.Angle, ConnectionPointFirst = line.ConnectionPointFirst, ConnectionPointSecond = line.ConnectionPointSecond, Lenght = line.Lenght, LineCenterX = line.LineCenterX };
                        newElement.StartPoint = Point.Parse(line.StartPoint);
                        newElement.EndPoint = Point.Parse(line.EndPoint);
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.FirstGridID)
                                {
                                    newElement.FirstGrid = grd;
                                    break;
                                }
                            }
                        }
                        foreach (AbstractElement fig in figures)
                        {
                            if (fig is AbstractGrid grd)
                            {
                                if (fig.ID == line.SecondGridID)
                                {
                                    newElement.SecondGrid = grd;
                                    break;
                                }
                            }
                        }
                        figures.Add(newElement);

                    }

                }
            }
            return figures;
        }

    }
}
