using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excercise3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excercise3.Tests
{
    [TestClass()]
    public class ArrayExtensionsTests
    {
        [DataTestMethod()]
        [DataRow(new int[] {1,2,3,4,5,6,7,8,9,10}, 55)]
        [DataRow(new int[] {}, 0)]
        [DataRow(new int[] {5}, 5)]
        [DataRow(new int[] {5,1}, 6)]
        public void SumTest(int[] data, int expected)
        {
            int actual = ArrayExtensions.Sum(data);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] {1,2}, new int[] {2,1})]
        [DataRow(new int[] {1}, new int[] {1})]
        [DataRow(new int[] {}, new int[] {})]
        [DataRow(new int[] {1,2,3,4,5,6,7,8,9,10}, new int[] {10,9,8,7,6,5,4,3,2,1})]
        [DataRow(new int[] {1,2,3}, new int[] {3,2,1})]
        public void ReverseTest(int[] data, int[] expected)
        {
            int[] actual = ArrayExtensions.Reverse(data);
            CollectionAssert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 1, 2 }, 2)]
        [DataRow(new int[] { 8 }, 8)]
        [DataRow(new int[] { }, -1)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10)]
        [DataRow(new int[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 1 }, 10)]
        [DataRow(new int[] { 1, 2, 3, 4, 5, 10, 7, 8, 9, 1 }, 10)]
        public void MaxTest(int[] data, int expected)
        {
            int actual = ArrayExtensions.Max(data);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow(new long[] { 1, 2 }, 1)]
        [DataRow(new long[] { 8 }, 8)]
        [DataRow(new long[] { }, -1)]
        [DataRow(new long[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1)]
        [DataRow(new long[] { 10, 2, 3, 4, 5, 6, 7, 8, 9, 1 }, 1)]
        [DataRow(new long[] { 10, 2, 3, 4, 5, 1, 7, 8, 9, 99 }, 1)]
        public void MinTest(long[] data, long expected)
        {
            long actual = ArrayExtensions.Min(data);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] {1,2}, 1)]
        [DataRow(new int[] {}, -1)]
        [DataRow(new int[] {1,2,3}, 2)]
        [DataRow(new int[] {4,4,4,4,4}, 4)]
        [DataRow(new int[] {2,3,3,2}, 2)]
        public void AverageTest(int[] data, int expected)
        {
            int actual = ArrayExtensions.Average(data);
            Assert.AreEqual(expected, actual);
        }

        [DataTestMethod()]
        [DataRow(new int[] { 1, 2 }, new int[] { 1, 2})]
        [DataRow(new int[] { }, new int[] { })]
        [DataRow(new int[] { 2, 1 }, new int[] { 1, 2})]
        [DataRow(new int[] { 3 ,4, 2, 1 }, new int[] { 1, 2, 3 , 4})]
        public void SortArrayTest(int[] data, int[] expected)
        {
            Assert.Fail();
        }
    }
}