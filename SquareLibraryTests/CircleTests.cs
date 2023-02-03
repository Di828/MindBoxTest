using FigureLibrary;

namespace SquareLibraryTests
{
    public class CircleTests
    {

        [TestCase(1, Math.PI)]
        [TestCase(2, 4 * Math.PI)]
        public void CircleSquareCorrectRadius(double radius, double answer)
        {
            Circle circle = new Circle(radius);
            var result = circle.Square;

            Assert.That(result, Is.EqualTo(answer));
        }

        [TestCase(-1)]
        public void CircleSquareIncorrectRadius(double radius)
        {
            Assert.Throws<ArgumentException>(() => new Circle(radius));
        }
    }
}