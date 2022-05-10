// See https://aka.ms/new-console-template for more information


using DanCodingTest;
using System.Diagnostics;


MaximumOutput sum = new MaximumOutput();
Random random = new Random();
int[] arr = { 2,1 };
//var arr = (from p in Enumerable.Range(0, 5000000)
//           select random.Next(0, 99)).ToArray();
var watch = Stopwatch.StartNew();
int n = arr.Length;
var output =sum.findMaxValuesStolen(arr);
Console.WriteLine(output);
watch.Stop();
Console.WriteLine($"Execution Time:{watch.ElapsedMilliseconds} ms");



