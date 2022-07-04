﻿
using IntroOOP;
using Utilities;

ReadingDataTest.Run();

var list1 = new RefList<int>();

list1.AddFirst(1);
var node = list1.AddFirst(2);
list1.AddFirst(3);


list1.AddBefore(node, -100);
list1.AddAfter(node, 100);

var sum = list1.Where(value => value % 2 == 0).Sum();

list1.Clear();

//list1.Remove(list1.First);
//list1.Remove(list1.Last);
//list1.Remove(node);

var list2 = new RefList<int>();

list2.AddLast(3);
list2.AddLast(2);
list2.AddLast(1);
list2.AddAfter(node, 101);

foreach (var value in list1)
    Console.WriteLine(value);


//var list_node = new RefList<int>.Node(5);

Console.WriteLine("Hello, World!");
