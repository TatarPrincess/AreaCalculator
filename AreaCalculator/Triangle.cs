
namespace AreaCalculator
{
    public class Triangle : IAreaCalculator
    {
        private double _side1;
        private double _side2;
        private double _side3;
        public bool isRight;

        public double Side1
        {
            get => _side1;
            set {
                if (CheckSideLength(value)) _side1 = value;
            }
        }
        public double Side2
        {
            get => _side2;
            set
            {
                if (CheckSideLength(value)) _side2 = value;
            }
        }
        public double Side3
        {
            get => _side3;
            set
            {
                if (CheckSideLength(value)) _side3 = value;
            }
        }
        public Triangle(double side1, double side2, double side3)
        {
            Side1 = side1;
            Side2 = side2;
            Side3 = side3;
            isRight = CheckIfTriangleIsRight();
        }
        public double CalculateArea()
        {
            double semiPerimeter = (Side1 + Side2 + Side3)/2;
            return Math.Sqrt(semiPerimeter * (semiPerimeter - Side1) * (semiPerimeter - Side2) * (semiPerimeter - Side3));
        }
        private static bool CheckSideLength(double sideLength) => (sideLength <= 0) 
                                                           ? throw new ArgumentOutOfRangeException("Сторона треугольника должна быть больше 0")
                                                           : true;
        private bool CheckIfTriangleIsRight() => Math.Pow(Side3, 2) == (Math.Pow(Side2, 2) + Math.Pow(Side1, 2));
        
        
         
    }
}
