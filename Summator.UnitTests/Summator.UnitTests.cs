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
            var nums = new int[] { };
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
        [Test]
        public void Test_Summator_PositiveAndNegativeNumber()
        {
            var nums = new int[] { -1, 2 };
            var actual = Summator.Sum(nums);
            var expected = 1;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_ZeroAndNegativeNumber()
        {
            var nums = new int[] { 0, -10 };
            var actual = Summator.Sum(nums);
            var expected = -10;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_ZeroAndPositiveNumber()
        {
            var nums = new int[] { 5 , 0 };
            var actual = Summator.Sum(nums);
            var expected = 5;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_TwoPositiveDoubleNumber()
        {
            var nums = new double[] { 10.0 , 0.5 };
            var actual = Summator.Sum(nums);
            var expected = 10.5;
            Assert.AreEqual(expected, actual);
        }
        [Test]
        public void Test_Summator_TwoNegativeDoubleNumber()
        {
            var nums = new double[] { -1.0, -0.5 };
            var actual = Summator.Sum(nums);
            var expected = -1.5;
            Assert.AreEqual(expected, actual);
        }
      }
    }

   