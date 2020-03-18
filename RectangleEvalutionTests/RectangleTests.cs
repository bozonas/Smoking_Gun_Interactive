using Microsoft.VisualStudio.TestTools.UnitTesting;
using RectangleEvalution;

namespace RectangleEvalutionTests
{
    [TestClass]
    public class RectangleTests
    {
        [DataRow(10, 10, 1, 1, 2, 2)]
        [DataRow(10, 10, -10, 1, -2, 2)]
        [DataRow(10, 10, 1, -10, 2, -2)]
        [TestMethod]
        public void IsPointInside_PointInside_True(float width,
            float height, float x, float y, float pointX, float pointY)
        {
            // Arrange
            var rectangle = new Rectangle(width, height, x, y);
            var point = new Point2D(pointX, pointY);

            // Act
            var result = rectangle.IsPointInside(point);

            // Assert
            Assert.IsTrue(result);
        }

        [DataRow(10, 10, 1, 1, 12, 1)]
        [DataRow(10, 10, 1, 1, 2, -2)]
        [TestMethod]
        public void IsPointInside_PointOutside_False(float width,
            float height, float x, float y, float pointX, float pointY)
        {
            // Arrange
            var rectangle = new Rectangle(width, height, x, y);
            var point = new Point2D(pointX, pointY);

            // Act
            var result = rectangle.IsPointInside(point);

            // Assert
            Assert.IsFalse(result);
        }

        [DataRow(5, 5, 1, 1, 5, 5, 7, 7)]
        [DataRow(5, 5, 1, 1, 5, 5, -7, 7)]
        [DataRow(5, 5, 1, 1, 5, 5, 7, -7)]
        [TestMethod]
        public void DoesRectangleIntersect_RectangleNotIntersect_False(float widthA,
            float heightA, float xA, float yA, float widthB, float heightB, float xB, float yB)
        {
            // Arrange
            var rectangleA = new Rectangle(widthA, heightA, xA, yA);
            var rectangleB = new Rectangle(widthB, heightB, xB, yB);

            // Act
            var result = rectangleA.DoesRectangleIntersect(rectangleB);

            // Assert
            Assert.IsFalse(result);
        }

        [DataRow(5, 5, 1, 1, 5, 5, 2, 2)]
        [DataRow(5, 5, 1, 1, 5, 5, 1, 1)]
        [DataRow(5, 5, 1, 1, 5, 5, 0, 2)]
        [TestMethod]
        public void DoesRectangleIntersect_RectangleIntersect_True(float widthA,
            float heightA, float xA, float yA, float widthB, float heightB, float xB, float yB)
        {
            // Arrange
            var rectangleA = new Rectangle(widthA, heightA, xA, yA);
            var rectangleB = new Rectangle(widthB, heightB, xB, yB);

            // Act
            var result = rectangleA.DoesRectangleIntersect(rectangleB);

            // Assert
            Assert.IsTrue(result);
        }
    }
}
