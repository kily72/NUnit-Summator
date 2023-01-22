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

        [Test]
        public void Test_Summator_ZeroNumber()
        {
            var nums = new int[] {};
            var actual = Summator.Sum(nums);
            var expected = 0;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_SummatorBigNumbers()
        {
            var nums = new[] { 2000000000, 2000000000, };
            var actual = Summator.Sum(nums);
            var expected = 4000000000;
            Assert.AreEqual(expected, actual);
        }
      }
    }

   