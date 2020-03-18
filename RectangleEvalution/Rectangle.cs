namespace RectangleEvalution
{
    public class Rectangle
    {
        public float Width { get; private set; }
        public float Height { get; private set; }
        public Point2D InitPoint { get; private set; }

        public Rectangle(float width, float height, float x, float y) =>
            (Width, Height, InitPoint) = (width, height, new Point2D(x, y));

        /// <summary>
        /// Copy constructor
        /// </summary>
        /// <param name="rectangle"></param>
        public Rectangle(Rectangle rectangle) =>
            (Width, Height, InitPoint) = (rectangle.Width, rectangle.Height, rectangle.InitPoint);


        public bool IsPointInside(Point2D point) => IsPointInside(point.X, point.Y);

        private bool IsPointInside(float x, float y) =>
            x >= InitPoint.X && x <= InitPoint.X + Width
            && y >= InitPoint.Y && y <= InitPoint.Y + Height;

        public bool DoesRectangleIntersect(Rectangle rectangle) =>
            IsPointInside(rectangle.InitPoint.X, rectangle.InitPoint.Y)
                || IsPointInside(rectangle.InitPoint.X + rectangle.Width, rectangle.InitPoint.Y)
                || IsPointInside(rectangle.InitPoint.X, rectangle.InitPoint.Y + rectangle.Width)
                || IsPointInside(rectangle.InitPoint.X + rectangle.Width, rectangle.InitPoint.Y + rectangle.Width);
    }
}
