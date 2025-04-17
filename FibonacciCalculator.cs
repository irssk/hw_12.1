using System;
using System.Collections.Generic;

public static class FibonacciCalculator
{
    private static readonly Dictionary<int, int> _cache = new();

    public static int GetFibonacci(int n)
    {
        if (n < 0)
            throw new ArgumentException("The order of Fibonacci numbers cannot be negative.");

        if (n == 0) return 0;
        if (n == 1) return 1;

        if (_cache.TryGetValue(n, out int cachedValue))
            return cachedValue;

        int result = GetFibonacci(n - 1) + GetFibonacci(n - 2);
        _cache[n] = result;
        return result;
    }
}