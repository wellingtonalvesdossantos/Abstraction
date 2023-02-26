// See https://aka.ms/new-console-template for more information
using Abstraction.Core.Extensions;
using Abstraction.Core.Logger;
using Abstraction.Core.Models;
using Abstraction.Core.Repository;
using Abstraction.Core.Taker;
using System;
using System.Collections.Generic;

//Ini Taker
ITaker<int> taker; int value;

taker = new Abstraction.Core.Taker.Queue<int>();
taker.AddRange(1, 2, 3);
value = taker.Take();                   //valor esperado 1
Console.WriteLine($"{value} [{taker.List.JoinIntoString()}]");

taker = new Abstraction.Core.Taker.Stack<int>();
taker.AddRange(1, 2, 3);
value = taker.Take();                   //valor esperado 3
Console.WriteLine($"{value} [{taker.List.JoinIntoString()}]");
//End Taker

Console.WriteLine($"\n{new string('*', 50)}\n");

//Ini Logger
ILogger logger;

logger = new ConsoleLogger();
logger.LogError("Log error");
Console.WriteLine("Texto normal 1");
logger.LogWarning("Log warning");
Console.WriteLine("Texto normal 2");
logger.LogInfo("Log info");
Console.WriteLine("Texto normal 3");

logger = new FakeLogger();
logger.LogError("Log error");           //esperado nada
Console.WriteLine("Texto normal 1");
logger.LogWarning("Log warning");       //esperado nada
Console.WriteLine("Texto normal 2");
logger.LogInfo("Log info");             //esperado nada
Console.WriteLine("Texto normal 3");

//End Logger

Console.WriteLine($"\n{new string('*', 50)}\n");

//Ini Repository
IRepository<State> repository;

repository = new StateFileRepository();
Console.WriteLine($"{repository.Count()} [{repository.GetAll().JoinIntoString()}]");    //esperado 3

repository = new InMemoryRepository<State>();
repository.Add(new State("AC", "Acre"));
Console.WriteLine($"{repository.Count()} [{repository.GetAll().JoinIntoString()}]");    //esperado 1

//End Repository