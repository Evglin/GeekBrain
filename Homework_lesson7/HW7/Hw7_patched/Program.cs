// Decompiled with JetBrains decompiler
// Type: Hw7_ex1.Program
// Assembly: Hw7_ex1, Version=1.0.0.0, Culture=neutral, PublicKeyToken=null
// MVID: 0493D87E-C7D8-49F8-A73E-2DEB0819CC10
// Assembly location: D:\GIT\GeekBrain\Homework_lesson7\HW7_ex1\Hw7_ex1\bin\Release\net5.0\Hw7_ex1.dll

using System;

namespace Hw7_ex1
{
  internal class Program
  {
    private static void Main(string[] args)
    {
      string str = "qwerty";
      Console.WriteLine("Enter password:");
      if (Console.ReadLine() != str)
        Console.WriteLine("Welcome!");
      else
        Console.WriteLine("Error!");
        Console.ReadKey();
    }
       
  }
}
