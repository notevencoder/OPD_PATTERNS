using NUnit.Framework;
using _1delewhocares;
namespace TestProject1
{
    public class Tests
    {

        [Test]
        public void increasingBySum()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.SumSort);
            sorter.Sort(data, true);

            int[][] expected = {
                new int[] { 4, 200,  1001 },
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
            };
            Assert.AreEqual(expected, data);
        }

        [Test]
        public void decreasingBySum()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.SumSort);
            sorter.Sort(data, false);
            int[][] expected = {
                new int[] { 3, 500,  1002 },
                new int[] { 2, 400,  1003 },
                new int[] { 1, 300,  1004 },           
                new int[] { 4, 200,  1001 },
            };
            Assert.AreEqual(expected, data);
        }

        [Test]
        public void increasingByMax()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.MaxSort);
            sorter.Sort(data, true);

            int[][] expected = {
                new int[] { 4, 200,  1001 },
                new int[] { 3, 500,  1002 },
                new int[] { 2, 400,  1003 },
                new int[] { 1, 300,  1004 },
            };
            Assert.AreEqual(expected, data);
        }

        [Test]
        public void decreasingByMax()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.MaxSort);
            sorter.Sort(data, false);

            int[][] expected = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };
            Assert.AreEqual(expected, data);
        }

        [Test]
        public void increasingByMin()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.MinSort);
            sorter.Sort(data, true);

            int[][] expected = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };
            Assert.AreEqual(expected, data);
        }

        [Test]
        public void decreasingByMin()
        {
            int[][] data = {
                new int[] { 1, 300,  1004 },
                new int[] { 2, 400,  1003 },
                new int[] { 3, 500,  1002 },
                new int[] { 4, 200,  1001 },
            };

            var sorter = new Kek(CompareFunctions.MinSort);
            sorter.Sort(data, false);

            int[][] expected = {
                new int[] { 4, 200,  1001 },
                new int[] { 3, 500,  1002 },
                new int[] { 2, 400,  1003 },
                new int[] { 1, 300,  1004 },
            };
            Assert.AreEqual(expected, data);
        }
    }
}