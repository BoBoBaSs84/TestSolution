using System;
using System.Collections.Generic;

namespace ListTutorial
{
    class Program
    {
        static void WorkingWithStrings()
        {
            var names = new List<string> { "Robert", "Ana", "Felipe" };
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            names.Add("Maria");
            names.Add("Bill");
            string s_NameToRemove = "Ana";
            names.Remove(s_NameToRemove);
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list and removed {s_NameToRemove} from the list");
            Console.WriteLine($"The list has {names.Count} people in it");

            var index = names.IndexOf("Felipe");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf retunrs {index}");
            }
            else
            {
                Console.WriteLine($"The Name {names[index]} is at index {index}");
            }
            index = names.IndexOf("Not Found");
            if (index == -1)
            {
                Console.WriteLine($"When an item is not found, IndexOf returns {index}");
            }
            else
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }
            int indexCount = names.Count;
            int indexStart;
            for (indexStart = 0; indexStart < indexCount; indexStart++)
            {
                Console.WriteLine($"The name {names[indexStart]} is at index {indexStart} from {indexCount}");
            }
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}! You where sorted.");
            }
        }
        static void Main(string[] args)
        {
            //WorkingWithStrings();
            var fibonacciNumbers = new List<int> { 1, 1 };
            while (fibonacciNumbers.Count < 20)
            {
                var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
                var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
                
                fibonacciNumbers.Add(previous + previous2);
            }
            foreach (var item in fibonacciNumbers) 
                Console.WriteLine(item);
        }
    }
}
