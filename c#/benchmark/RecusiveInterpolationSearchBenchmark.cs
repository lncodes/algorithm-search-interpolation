using BenchmarkDotNet.Attributes;

namespace Lncodes.Algorithm.Search.Interpolation.Benchmark
{
    [MinColumn]
    [MaxColumn]
    [MemoryDiagnoser]
    public class RecusiveInterpolationSearchBenchmark : InterpolationSearchBenchmark
    {
        private readonly RecusiveInterpolationSearch _recusiveInterpolationSearch = new RecusiveInterpolationSearch();
    
        [Benchmark]
        public int Search() =>
            _recusiveInterpolationSearch.Search(Data, Element, default, Data.Length - 1);
    }
}
