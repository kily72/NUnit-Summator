namespace Summator.UnitTests
{
    public class SummatorTests
    {
        [Test]
       public void Test_SummatorTwoPositiveNumbers()
        {
            var nums = new[] { 1, 2, };
            var actual = Summator.Sum(nums);
            var expected = 3;
            Assert.AreEqual(expected, actual);
            }

        [Test]
        public void Test_SummatorTwoNegativeNumbers()
        {
            var nums = new[] { -1, -99, };
            var actual = Summator.Sum(nums);
            var expected = -100;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SummatorOnePositiveNumbers()
        {
            var nums = new[] { 6 };
            var actual = Summator.Sum(nums);
            var expected = 6;
            Assert.AreEqual(expected, actual);
        }
      }
    }

   