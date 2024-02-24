
namespace AreaCalculator
{
    public class Circle : IAreaCalculator
    {
        public int Radius { get ; set ; }
        public Circle(int radius)
        {
            Radius = radius;
        }
        public double CalculateArea() => Math.Round((Math.PI * Math.Pow(Radius, 2)), 2, MidpointRounding.AwayFromZero);
   
    }
}
