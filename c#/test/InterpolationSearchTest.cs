using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Interpolation.Test
{
    public sealed class InterpolationSearchTest
    {
        [Theory]
        [ClassData(typeof(InterpolationSearchTheoryData))]
        public void Search_Interpolation_ShouldTrue(IReadOnlyList<decimal> data, decimal element, int expected)
        {
            var instance = new InterpolationSearch();
            var actual = instance.Search(data, element);
            Assert.Equal(expected, actual);
        }
    }
}
