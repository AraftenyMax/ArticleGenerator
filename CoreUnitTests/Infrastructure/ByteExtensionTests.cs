using NUnit.Framework;
using RandomArticleGenerator.Infrastructure;

namespace CoreUnitTests.Infrastructure
{
    class ByteExtensionTests
    {
        [SetUp]
        public void Setup()
        {

        }
        [Test]
        public void ComparesArraysCorrectly()
        {
            byte[,] array1 = { { 1, 2 }, { 2, 3 }, { 4, 5 } };
            byte[,] array2 = array1.Clone() as byte[,];
            bool equal = ByteExtension.AreEqual(array1, array2);
            Assert.IsTrue(equal);
        }
        [Test]
        public void ComparesNotDimesionalEqualArrays()
        {
            byte[,] array1 = { { 1, 2 }, { 2, 3 }, { 4, 5 } };
            byte[,] array2 = { { 1, 2 } };
            bool equal = ByteExtension.AreEqual(array1, array2);
            Assert.IsFalse(equal);
        }
        [Test]
        public void ComparesNotEqualContentArrays()
        {
            byte[,] array1 = { { 1, 8 }, { 2, 7 }, { 4, 6 } };
            byte[,] array2 = { { 1, 2 }, { 2, 3 }, { 4, 5 } };
            bool equal = ByteExtension.AreEqual(array1, array2);
            Assert.IsFalse(equal);
        }
    }
}
