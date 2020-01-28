using System.Collections.Generic;
using ivend.Interfaces;

namespace ivend.Models
{
  class Machine
  {
    public List<IPurchasable> ItemList = new List<IPurchasable>();

    private void Setup()
    {
      Food burrito = new Food("Burrito", 2.00f, "A1", 5);
      Food noodles = new Food("Noodles", 0.50f, "A2", 7);
      Electronics headphones = new Electronics("Headphones", 4.90f, "A3", 3);

      ItemList.AddRange(new IPurchasable[] { burrito, noodles, headphones });
    }

    public Machine()
    {
      Setup();
    }
  }
}