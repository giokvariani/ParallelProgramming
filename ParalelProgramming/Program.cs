// See https://aka.ms/new-console-template for more information
using ParalelProgramming;

Console.WriteLine("Hello, World!");


var houses = Enumerable.Range(1, 25).Select(x => new House(x)).ToList();


//პარალელურად გაშვება
Parallel_Run.Run(houses);
//პარალელურად გაშვება
Console.WriteLine();
Console.WriteLine();
Console.WriteLine();
//სინქრონულად გაშვება
Synchronous_Run.Run(houses);
//სინქრონულად გაშვება