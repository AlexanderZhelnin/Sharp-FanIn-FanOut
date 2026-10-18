using BenchmarkDotNet.Attributes;
using Microsoft.VSDiagnostics;
using System.Linq;

namespace Fan_in__Fan_out;

[CPUUsageDiagnoser]
[MemoryDiagnoser]
public class Benchmarks
{
    private int[] data;
    private int[] resultData;

    [GlobalSetup]
    public void Setup()
    {
        data = new int[100_000_000];
        for (var i = 0; i < data.Length; i++)
            data[i] = i;
    }

    [Benchmark]
    public void FanInFanOut()
    {
        resultData = data.AsParallel()                         
                         .Select(value => value * 2)
                         .ToArray();
    }

    [Benchmark]
    public void Sequential()
    {
        resultData = data.Select(value => value * 2)
                         .ToArray();
    }

}