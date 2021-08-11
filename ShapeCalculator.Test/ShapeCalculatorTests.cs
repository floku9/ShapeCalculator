using ShapeCalculator.Shapes;
using System;
using Xunit;

namespace ShapeCalculator.Tests
{
    public class ShapeCalculatorTests
    {
        /// <summary>
        /// ���� ����������� ������� � �����
        /// </summary>
        [Fact]
        public void CircleNegativeRadius()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Circle(-3));
        }

        /// <summary>
        /// ���� ������������ �������� ������� ����� 
        /// </summary>
        [Fact]
        public void CircleGetArea()
        {
            //Arrange
            Circle circle = new Circle(4);

            //Act
            double area = circle.GetArea();

            //Assert
            Assert.Equal(50.26548245743669, area);
        }

        /// <summary>
        /// ���� ������������� ������ ������������
        /// </summary>
        [Fact]
        public void TriangleNegativeSide()
        {
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(-4, 2, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, -2, 5));
            Assert.Throws<ArgumentOutOfRangeException>(() => new Triangle(4, 2, -5));
        }

        /// <summary>
        /// ���� ������, ���� ������� ������� ������������ ������ ����� ���� ������ ������
        /// </summary>
        [Fact]
        public void LargerTriangleSideGreater()
        {
            Assert.Throws<ArgumentException>(() => new Triangle(20, 1, 1));
        }

        /// <summary>
        /// ���� ������������ �������� ������� ������������
        /// </summary>
        [Fact]
        public void TriangleGetArea()
        {
            //Arrange
            Triangle triangle = new Triangle(3, 4, 5);

            //Act
            double area = triangle.GetArea();

            //Assert
            Assert.Equal(6, area);
        }

        /// <summary>
        /// ���� �������������� ������������
        /// </summary>
        [Fact]
        public void RightTriangle()
        {
            //Arrange
            Triangle triangle = new Triangle(10, 8, 6);

            //Act
            bool isRight = triangle.IsRight();

            //Assert
            Assert.True(isRight);
        }

        /// <summary>
        /// ���� ���������������� ������������
        /// </summary>
        [Fact]
        public void NotRightTriangle()
        {
            Triangle triangle = new Triangle(4, 4, 2);

            //Act
            bool isRight = triangle.IsRight();

            //Assert
            Assert.False(isRight);
        }
    }
}
