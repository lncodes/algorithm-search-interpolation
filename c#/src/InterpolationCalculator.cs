namespace Lncodes.Algorithm.Search.Interpolation
{
    public static class InterpolationCalculator
    {
        public static int GetInterpolationValue(decimal x, decimal x1, decimal x2, decimal y1, decimal y2) =>
            (int)(y1 + ((x - x1) * ((y2 - y1) / (x2 - x1))));
    }
}
