using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Interpolation.Test
{

    public sealed class RecusiveInterpolationSearchTest
    {
        [Theory]
        [ClassData(typeof(InterpolationSearchTheoryData))]
        public void Search_Interpolation_ShouldTrue(IReadOnlyList<decimal> data, decimal element, int expected)
        {
            var instance = new RecusiveInterpolationSearch();
            var actual = instance.Search(data, element, default, data.Count - 1);
            Assert.Equal(expected, actual);
        }
    }
}
