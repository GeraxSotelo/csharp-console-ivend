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
        case 'e':
          _running = false;
          break;
        case 'n':
        case 'd':
        case 'q':
          Service.IncreaseCredit(keyChar);
          Service.PrintItems();
          break;
        case 'o':
          OrderInput();
          break;
        default:
          Console.Clear();
          Console.WriteLine("Invalid Selection");
          Service.PrintItems();
          break;
      }
    }

    public void OrderInput()
    {
      Console.WriteLine("Enter Selection");
      string selection = Console.ReadLine().ToUpper();
      switch (selection)
      {
        case "E":
          _running = false;
          break;
        case "A1":
        case "A2":
        case "B1":
        case "B2":
          Service.Purchase(selection);
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