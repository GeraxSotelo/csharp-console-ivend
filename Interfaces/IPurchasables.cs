namespace ivend.Interfaces
{
  interface IPurchasable
  {
    string Title { get; set; }
    float Price { get; set; }
    string Location { get; set; }
    int Quantity { get; set; }

    string GetVendingMachineItem();
  }
}