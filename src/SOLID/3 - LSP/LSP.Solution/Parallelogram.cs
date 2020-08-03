namespace SOLID.LSP.Solution
{
    public abstract class Parallelogram
    {
        protected Parallelogram(int height, int width)
        {
            Height = height;
            Width = width;
        }

        public double Height { get; set; }
        public double Width { get; set; }

        public double Area { get { return Height * Width; } }
    }
}
