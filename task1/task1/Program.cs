//task 1 summation of numbers from 1 to n  
//case 1 : using for loop
//case 2 : using formula (n * (n + 1) / 2)
//adding validation for value of n

using System.Diagnostics;


// ? ==> accept null value

string? input;
int n;

// Input validation
do
{
    Console.WriteLine("Enter a positive valid integer n:");
    input = Console.ReadLine();
}
while (string.IsNullOrEmpty(input) || !int.TryParse(input, out n) || n <= 0);

Stopwatch stopwatch = new Stopwatch();

// First solution: using for loop
int sum = 0;

stopwatch.Start();

for (int i = 1; i <= n; i++)
{
    sum += i;
}
stopwatch.Stop();

Console.WriteLine($"Time taken for for loop: {stopwatch.Elapsed.TotalMilliseconds} ms");
Console.WriteLine($"Sum of numbers from 1 to {n} using for loop is: {sum}");

// Reset stopwatch 
stopwatch.Reset();

// Second solution: using formula
stopwatch.Start();

int formulaSum = n * (n + 1) / 2;

stopwatch.Stop();
Console.WriteLine($"Time taken for formula calculation: {stopwatch.Elapsed.TotalMilliseconds} ms");
Console.WriteLine($"Sum of numbers from 1 to {n} using formula is: {formulaSum}");