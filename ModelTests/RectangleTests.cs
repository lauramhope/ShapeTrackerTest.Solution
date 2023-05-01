using Microsoft.VisualStudio.TestTools.UnitTesting;
using ShapeTracker.Models;
using System;

namespace ShapeTracker.Tests
{
  [TestClass]
  public class RectangleTests : IDisposable
  {
    public void Dispose()
    {
      Rectangle.ClearAll();
    }

    [TestMethod]
    public void RectangleConstructor_CreatesInstanceOfRectangle_Rectangle()
    {
      Rectangle newRectangle = new Rectangle(2, 3);
      Assert.AreEqual(typeof(Rectangle), newRectangle.GetType());
    }

    [TestMethod]
    public void GetLength_ReturnsLength_Int()
    {
      // Arrange
      int length = 3;
      int width = 4;
      Rectangle newRectangle = new Rectangle(length, width);
      // Act
      int result = newRectangle.Length;
      // Assert
      Assert.AreEqual(length, result);
    }

    [TestMethod]
    public void SetLength_SetsValueOfLength_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3, 3);
      int newLength = 44;
      // Act
      newRectangle.Length = newLength;
      // Assert
      Assert.AreEqual(newLength, newRectangle.Length);
    }

    [TestMethod]
    public void GetWidth_ReturnsWidth_Int()
    {
      // Arrange
      int length = 3;
      int width = 4;
      Rectangle newRectangle = new Rectangle(length, width);
      // Act
      int result = newRectangle.Width;
      // Assert
      Assert.AreEqual(width, result);
    }

    [TestMethod]
    public void SetWidth_SetsValueOfWidth_Void()
    {
      // Arrange
      Rectangle newRectangle = new Rectangle(3, 3);
      int newWidth = 44;
      // Act
      newRectangle.Width = newWidth;
      // Assert
      Assert.AreEqual(newWidth, newRectangle.Width);
    }
  }
}