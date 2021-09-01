using Xunit;
using System.Collections.Generic;

namespace Lncodes.Algorithm.Search.Interpolation.Test
{
    public sealed class InterpolationSearchTheoryData : TheoryData<IReadOnlyCollection<decimal>, decimal, int>
    {
        public InterpolationSearchTheoryData()
        {
            Add(new decimal[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 1, 0);
            Add(new decimal[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 5, 4);
            Add(new List<decimal> { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 }, 10, 9);
        }
    }
}