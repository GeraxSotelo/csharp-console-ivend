using System;
using ivend.Services;

namespace ivend.Controllers
{
  class IvendController
  {
    private IvendService Service { get; set; } = new IvendService();
    private bool _running = true;

    public void Run()
    {
      Service.PrintItems();//fills Service.Messages with the items
      while (_running)
      {
        PrintMessages();
        GetUserInput();
      }
      Console.Clear();
      Console.WriteLine("Goodbye");
    }

    private void PrintMessages()
    {
      foreach (string msg in Service.Messages)
      {
        Console.WriteLine(msg);
      }
      Service.Messages.Clear();
    }
    private void GetUserInput()
    {
      var key = Console.ReadKey();
      Console.Clear();
      var keyChar = key.KeyChar;
      switch (keyChar)
      {
        case 'q':
          _running = false;
          break;
        case 'd':
          Service.IncreaseCredit('d');
          Service.PrintItems();
          break;
        default:
          Console.WriteLine("Invalid Selection");
          Service.PrintItems();
          break;
      }
    }

  }
}