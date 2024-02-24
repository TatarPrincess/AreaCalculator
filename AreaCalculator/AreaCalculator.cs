
namespace AreaCalculator
{
    public class AreaCalculator 
    {
        public IAreaCalculator Figure { get; set; }
        public AreaCalculator(IAreaCalculator figure)
        {
            Figure = figure;
        }
        public double Calculate()
        {
            return Figure.CalculateArea();
        }
    }
}
