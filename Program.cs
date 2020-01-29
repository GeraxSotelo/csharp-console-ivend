using System;
using ivend.Controllers;

namespace ivend
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.Clear();
      IvendController ic = new IvendController();
      ic.Run();
    }
  }
}
