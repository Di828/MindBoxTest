namespace FigureLibrary
{
    public class Triangle : Figure
    {
        public double A { get; }
        public double B { get; }
        public double C { get; }

        public Triangle(double a, double b, double c)
        {
            if (a <= 0 || b <= 0 || c <= 0)
            {
                throw new ArgumentException("Throw exception because side cannot be less or equals to zero.");
            }

            var p = (a + b + c) / 2;
            if (p <= a || p <= b || p <= c)
            {
                throw new ArgumentException("Throw exception because triangle with those sides cannot exist");
            }

            (A, B, C) = (a, b, c);            
        }

        public override double Square { 
            get 
            {
                var p = (A + B + C) / 2;

                return Math.Sqrt(p * (p - A) * (p - B) * (p - C));
            } 
        }

        public bool IsRight { get { return A * A + B * B == C * C || A * A + C * C == B * B || B * B + C * C == A * A; } }
    }
}