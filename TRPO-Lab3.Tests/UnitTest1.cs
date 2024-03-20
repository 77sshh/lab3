using TRPO_Lab3.Lib;
namespace TRPO_Lab3.Tests
{
    public class Tests
    {
        [Test]
        public void Test1()
        {

            const double radius = 10;
            const double angledegrees = 90;
            const double expected = 28.5398;
            var area = Class1.CircleSegment(radius, angledegrees);
            Assert.AreEqual(expected, area, 0.01);
        }
        [Test]
        public void Test2()
        {
            const double radius = -20;
            const double angledegrees = -60;
            Assert.Throws<Exception>(() => Class1.CircleSegment(radius, angledegrees));
        }

    }
}