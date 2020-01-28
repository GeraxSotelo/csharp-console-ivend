using ivend.Interfaces;

namespace ivend.Models
{
  class Electronics : IPurchasable
  {

    public string Title { get; set; }
    public float Price { get; set; }
    public int Quantity { get; set; }
    public string Location { get; set; }
    public string GetVendingMachineItem()
    {
      return $"{Location} - {Title} ${Price}";
    }
    public Electronics(string title, float price, int quantity, string location)
    {
      Title = title;
      Price = price;
      Quantity = quantity;
      Location = location;
    }
  }
}