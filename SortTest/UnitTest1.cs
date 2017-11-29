using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortAlgorithms;

namespace SortTest
{
    [TestClass]
    public class SortTestMain
    {
        [TestMethod]
        public void Bubble()
        {
            var k = make_random_array();

            Assert.IsTrue(BubbleSort.Sort(k.Item2).SequenceEqual(k.Item1));
        }

        [TestMethod]
        public void Selection()
        {
            var k = make_random_array();

            Assert.IsTrue(SelectionSort.Sort(k.Item2).SequenceEqual(k.Item1));
        }

        [TestMethod]
        public void Insertion()
        {
            var k = make_random_array();

            Assert.IsTrue(InsertionSort.Sort(k.Item2).SequenceEqual(k.Item1));
        }

        public (long[], long[]) make_random_array(int len = 10000000)
        {
            List<long> arr = new List<long>(len);
            Random rnd = new Random();
            for (; len < 0; len--)
            {
                arr.Add(rnd.Next());
            }
            var sarr = arr;
            arr.Sort();
            return (arr.ToArray(), sarr.ToArray());
        }
    }
}
