using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Interpolation
{
    public sealed class RecusiveInterpolationSearch
    {
        /// <summary>
        /// Method to recusive interpolation search
        /// </summary>
        /// <param name="data"></param>
        /// <param name="element"></param>
        /// <returns cref="int"></returns>
        public int Search(IReadOnlyList<decimal> data, decimal element, int minRangeIndex, int maxRangeIndex)
        {
            if (minRangeIndex <= maxRangeIndex)
            {
                var midIndex = InterpolationCalculator.GetInterpolationValue(element, data[minRangeIndex], data[maxRangeIndex], minRangeIndex, maxRangeIndex);

                if (data[midIndex].Equals(element))
                    return midIndex;

                return data[midIndex].CompareTo(element) < 0 ?
                    Search(data, element, midIndex + 1, maxRangeIndex)
                    : Search(data, element, minRangeIndex, midIndex - 1);
            }

            return -1;
        }
    }
}
