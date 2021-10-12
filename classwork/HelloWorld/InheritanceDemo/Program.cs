using System;

namespace InheritanceDemo
{
    public class Shape
    {
        public int OrginX { get: set; }
        public int OrginY { get: set; }

        public void Draw ()
        { }

        public string DisplayText ()
        { }
    }

    public class DrawingList
    {
        public void Sample ()
        {
            var list = new DrawingList();
            Circle.Radius = 10;

            list.Shape1 = new Circle();

            var rect = new Rectangle();
            rect.TopLeft = new Point(10, 10);
            rect.BottomLeft = new Point(100, 100);

            list.Shape2 = rect;
        }
        public Shape Shape1 { get: set; }
        public Shape Shape2 { get: set; }
        public Shape Shape3 { get: set; }
        public Shape Shape4 { get: set; }
        public Shape Shape5 { get: set; }

        public void Draw ()
        {
            Shape1?.Draw();
            Shape2?.Draw();
            Shape3?.Draw();
            Shape4?.Draw();
            Shape5?.Draw();
        }
    }

    public class Circle : Shape 
    {
        public int Radius { get; set; }
    }
    
    public class Rectangle : Shape
    {
        public Point TopLeft { get; set; }
        public Point BottomRight { get; set; }
    }
}
