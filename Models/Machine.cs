using System.Collections.Generic;
using ivend.Interfaces;

namespace ivend.Models
{
  class Machine
  {
    public List<IPurchasable> ItemList = new List<IPurchasable>();
    public float Credit { get; set; } = 0.00f;

    private void Setup()
    {
      Food burrito = new Food("Burrito", 2.00f, "A1", 5);
      Food noodles = new Food("Noodles", 0.50f, "A2", 7);
      Electronics headphones = new Electronics("Headphones", 4.90f, "B1", 3);
      Electronics phoneCharger = new Electronics("Phone Charger", 9.99f, "B2", 5);

      ItemList.AddRange(new IPurchasable[] { burrito, noodles, headphones });
    }

    public Machine()
    {
      Setup();
    }
  }
}