//Task2 Printing numbers from 1 to n
// erasing comma in the end of the output
//optimize solution using StringBuilder


using System.Diagnostics;
using System.Text;

string? input;
int n;
// Input validation
do
{
    Console.WriteLine("Enter a positive valid integer n:");
    input = Console.ReadLine();
} while (string.IsNullOrEmpty(input) || !int.TryParse(input, out n) || n <= 0); 

Console.WriteLine("Printing numbers from 1 to n using ");
Stopwatch stopwatch = new Stopwatch();
stopwatch.Start();
// O(n log n) solution using for loop
for (int i = 1; i <= n; i++)
{
    Console.Write(i);
    if (i < n) // Avoid printing comma after the last number
    {
        Console.Write(", ");
    }
}
stopwatch.Stop();
Console.WriteLine($"Time taken for printing numbers from 1 to {n} using for loop: {stopwatch.Elapsed.TotalMilliseconds} ms");
// using StringBuilder for better performance

StringBuilder stringbulider = new StringBuilder();
stopwatch.Reset();
//O(n) solution using StringBuilder
for (int i = 1; i <= n; i++)
{
    stringbulider.Append($"i");
    if (i < n) // Avoid printing comma after the last number
    {
        stringbulider.Append(", ");
    }
}

Console.WriteLine(stringbulider.ToString());
stopwatch.Stop();

Console.WriteLine($"Time taken for printing numbers from 1 to {n} using StringBuilder: {stopwatch.Elapsed.TotalMilliseconds} ms");
