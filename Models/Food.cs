using ivend.Interfaces;

namespace ivend.Models
{
  class Food : IPurchasable
  {

    public string Title { get; set; }
    public float Price { get; set; }
    public string Location { get; set; }
    public int Quantity { get; set; }
    public string GetVendingMachineItem()
    {
      return $"{Location} - {Title} {Price:c}";
    }
    public Food(string title, float price, string location, int quantity)
    {
      Title = title;
      Price = price;
      Location = location;
      Quantity = quantity;
    }
  }
}