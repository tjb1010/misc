using System;
using System.Collections.Generic;

namespace myApp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Hello World!");
      Console.WriteLine($"The current time is {DateTime.Now}");
      System.Console.WriteLine("\n");
      System.Console.WriteLine("Practice Sesh");
      System.Console.WriteLine("-----------------");
      // Practice Below 

      System.Console.WriteLine("\nCalling Person class from Person.cs in Program.cs\n");
      // Instantiating new object of type Person and assigning 
      // values to the variables of the Person type object
      // then calling the Introduce() method from Person
      var john = new Person();
      john.FirstName = "John";
      john.LastName = "Smith";

      john.Introduce();

      var numbers = new List<int> { 1, 2, 3, 4, 5, 6 };
      var smallest = GetSmallest(numbers, 3);

      foreach (var number in smallest)
        System.Console.WriteLine(number);

    }

    public static List<int> GetSmallest(List<int> list, int count)
    {
      var smallest = new List<int>();

      while (smallest.Count < count)
      {
        var min = GetSmallest(list);
        smallest.Add(min);
        list.Remove(min);
      }

      return smallest;
    }
    public static int GetSmallest(List<int> list)
    {
      var min = list[0];
      for (var i = 1; i < list.Count; i++)
      {
        if (list[i] < min)
          min = list[i];
      }
      return min;
    }
  }
}
