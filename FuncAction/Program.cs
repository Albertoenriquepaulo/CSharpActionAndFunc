using System;
using System.Diagnostics;

var watch = Stopwatch.StartNew();
CountToNearlyInfinity(); //  <<<< Method to benchmark
watch.Stop();
Console.WriteLine(watch.Elapsed);

MeasureTime(() => CountToNearlyInfinity());
// Same above but converted as method group
MeasureTime(CountToNearlyInfinity);


var result = MeasureTimeFunc<int>(CalculateSomeResult);
Console.WriteLine($"The result is {MeasureTimeFunc<int>(() => CalculateSomeResult())}");

// Action is a delegate that not return or receive parameter
// public delegate void Action();
static void MeasureTime(Action input)
{
    var watch = Stopwatch.StartNew();
    input();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
}

static T MeasureTimeFunc<T>(Func<T> input)
{
    var watch = Stopwatch.StartNew();
    var result = input();
    watch.Stop();
    Console.WriteLine(watch.Elapsed);
    return result;
}

static void CountToNearlyInfinity()
{
    for (int i = 0; i < 1000000000; i++) ;
}

static int CalculateSomeResult()
{
    for (int i = 0; i < 1000000000; i++) ;
    return 42;
}