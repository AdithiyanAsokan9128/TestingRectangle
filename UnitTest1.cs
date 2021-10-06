using NUnit.Framework;
using Assignment2;

namespace TestRectangle
{
    public class Tests
    {
        [TestFixture]
        public class Class1
        {
            Rectangle rectangle = new Rectangle();

            [Test]
            public void TestGetLength()
            {
                int a = 0;
                int resGetLength = rectangle.GetLength(); //act
                Assert.AreEqual(resGetLength, a); //assert
            }
            [Test]
            public void TestSetLength()
            {
                int l = 8;
                int resSetLength = rectangle.SetLength(l); //act
                Assert.AreEqual(resSetLength, l); //assert
            }
            [Test]
            public void TestGetWidth()
            {
                int b = 0;
                int resGetWidth = rectangle.GetWidth(); //act
                Assert.AreEqual(resGetWidth, b); //assert
            }
            [Test]
            public void TestSetWidth()
            {
                int w = 8;
                int resSetLength = rectangle.SetWidtth(w); //act
                Assert.AreEqual(resSetLength, w); //assert
            }
            [Test]
            public void TestGetHeight()
            {
                int c = 0;
                int resGetLength = rectangle.GetHeight(); //act
                Assert.AreEqual(resGetLength, c); //assert
            }
            [Test]
            public void TestSetHeight()
            {
                int h = 8;
                int resSetLength = rectangle.Setheight(h); //act
                Assert.AreEqual(resSetLength, h); //assert
            }
            [Test]
            public void TestGetLength1()
            {
                int a = 0;
                int resGetLength = rectangle.GetLength(); //act
                Assert.AreEqual(resGetLength, a); //assert
            }
            [Test]
            public void TestSetLength1()
            {
                int l = 7;
                int resSetLength = rectangle.SetLength(l); //act
                Assert.AreEqual(resSetLength, l); //assert
            }
            [Test]
            public void TestGetWidth1()
            {
                int b = 0;
                int resGetWidth = rectangle.GetWidth(); //act
                Assert.AreEqual(resGetWidth, b); //assert
            }
            [Test]
            public void TestSetWidth1()
            {
                int w = 7;
                int resSetLength = rectangle.SetWidtth(w); //act
                Assert.AreEqual(resSetLength, w); //assert
            }
            [Test]
            public void TestGetHeight1()
            {
                int c = 0;
                int resGetLength = rectangle.GetHeight(); //act
                Assert.AreEqual(resGetLength, c); //assert
            }
            [Test]
            public void TestSetHeight1()
            {
                int h = 7;
                int resSetLength = rectangle.Setheight(h); //act
                Assert.AreEqual(resSetLength, h); //assert
            }
            [Test]
            public void TestGetLength2()
            {
                int a = 0;
                int resGetLength = rectangle.GetLength(); //act
                Assert.AreEqual(resGetLength, a); //assert
            }
            [Test]
            public void TestSetLength2()
            {
                int l = 6;
                int resSetLength = rectangle.SetLength(l); //act
                Assert.AreEqual(resSetLength, l); //assert
            }
            [Test]
            public void TestGetWidth2()
            {
                int b = 0;
                int resGetWidth = rectangle.GetWidth(); //act
                Assert.AreEqual(resGetWidth, b); //assert
            }
            [Test]
            public void TestSetWidth2()
            {
                int w = 6;
                int resSetLength = rectangle.SetWidtth(w); //act
                Assert.AreEqual(resSetLength, w); //assert
            }
            [Test]
            public void TestGetHeight2()
            {
                int c = 0;
                int resGetLength = rectangle.GetHeight(); //act
                Assert.AreEqual(resGetLength, c); //assert
            }
            [Test]
            public void TestSetHeight2()
            {
                int h = 6;
                int resSetLength = rectangle.Setheight(h); //act
                Assert.AreEqual(resSetLength, h); //assert
            }
            [Test]
            public void volumeOfRectangle()
            {
                int a = 2, b = 3, c = 4;//arrange
                rectangle.SetLength(a);//arrange
                rectangle.SetWidtth(b);//arrange
                rectangle.Setheight(c);
                int resVolume = rectangle.GetVolume(); //act
                Assert.AreEqual(resVolume, 24); //assert
            }
            [Test]
            public void volumeOfRectangle1()
            {
                int a = 3, b = 3, c = 2;//arrange
                rectangle.SetLength(a);//arrange
                rectangle.SetWidtth(b);//arrange
                rectangle.Setheight(c);
                int resVolume = rectangle.GetVolume(); //act
                Assert.AreEqual(resVolume, 18); //assert
            }
            [Test]
            public void volumeOfRectangle2()
            {
                int a = 2, b = 2, c = 3;//arrange
                rectangle.SetLength(a);//arrange
                rectangle.SetWidtth(b);//arrange
                rectangle.Setheight(c);
                int resVolume = rectangle.GetVolume(); //act
                Assert.AreEqual(resVolume, 12); //assert
            }

        }
    }
}
