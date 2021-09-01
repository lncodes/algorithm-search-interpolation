using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Interpolation.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class RegulerInterpolationSearchBenchmark : InterpolationSearchBenchmark
    {
        private readonly InterpolationSearch _interpolationSearch = new InterpolationSearch();

        [Benchmark]
        public int Search() =>
            _interpolationSearch.Search(Data, Element);
    }
}
