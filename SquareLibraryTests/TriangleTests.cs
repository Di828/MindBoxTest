﻿using FigureLibrary;

namespace SquareLibraryTests
{
    public class TriangleTests
    {
        [TestCase(3, 4, 5, 6, true)]
        [TestCase(2, 2, 2, 1.7320508075688772d, false)]
        public void TriangleSquareCorrectInput(double a, double b, double c, double answer, bool isRight)
        {
            var triangle = new Triangle(a, b, c);            

            Assert.That(triangle.Square, Is.EqualTo(answer));
            Assert.That(triangle.IsRight, Is.EqualTo(isRight));
        }

        [TestCase(-1, 2, 3)]
        [TestCase(3, 0, 3)]
        [TestCase(1, 1, 3)]
        public void TriangleSquareIncorrectInput(double a, double b, double c)
        {           
            Assert.Throws<ArgumentException>(() => new Triangle(a, b, c));
        }        
    }
}
