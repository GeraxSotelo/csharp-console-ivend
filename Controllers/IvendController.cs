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
      }
      _running = false;
    }

    private void PrintMessages()
    {
      foreach (string msg in Service.Messages)
      {
        Console.WriteLine(msg);
      }
      Service.Messages.Clear();
    }
  }
}