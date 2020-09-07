using System;
using System.Collections.Generic;
using System.Text;

namespace RandomArticleGenerator.Infrastructure
{
    public static class ByteExtension
    {
        public static bool DimensionsAreEqual(byte[,] array1, byte[,] array2, int dimensionNumber)
        {
            return array1.GetLength(dimensionNumber) == array2.GetLength(dimensionNumber);
        }

        public static bool TwoDimensionalWithSameLength(byte[,] array1, byte[,] array2)
        {
            bool verdict = true;
            bool firstDimesionEqual = DimensionsAreEqual(array1, array2, 0);
            bool secondDimensionEqual = DimensionsAreEqual(array1, array2, 1);
            if (!firstDimesionEqual || !secondDimensionEqual)
            {
                verdict = false;
            }
            return verdict;
        }

        public static bool CompareArrays(byte[,] array1, byte[,] array2)
        {
            for (int i = 0; i < array1.GetLength(0); i++)
            {
                for (int j = 0; j < array1.GetLength(1); j++)
                {
                    int valueArr1 = array1[i, j];
                    int valueArr2 = array2[i, j];
                    if (valueArr1 != valueArr2)
                    {
                        return false;
                    }
                }
            }
            return true;
        }
        public static bool AreEqual(this byte[,] array1, byte[,] array2)
        {
            bool equalDimensions = TwoDimensionalWithSameLength(array1, array2);
            if (!equalDimensions)
            {
                return false;
            }
            bool comparsionResult = CompareArrays(array1, array2);
            return comparsionResult;
        }
    }
}
