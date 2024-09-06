var task1 = Task.Run(() =>
{
    Console.WriteLine("Task 1 completed!");
});

var task2 = Task.Run(() =>
{
    Console.WriteLine(1000000 + 2000000);
    Console.WriteLine("Task 2 completed!");
});

var task3 = Task.Run(() =>
{
    Thread.Sleep(5000);
    Console.WriteLine("Task 3 completed!");
});

Task.WaitAll([task1, task2, task3]);
Console.WriteLine("Completed");
