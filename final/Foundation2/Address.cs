public class Address
{
  private string _street;
  private string _city;
  private string _state;
  public string _country;

  public Address(string street, string city, string state, string country)
  {
    _street = street;
    _city = city;
    _state = state;
    _country = country;
  }

  public void AdressDescription()
  {
   Console.WriteLine($"{_street}");
   Console.WriteLine($"{_city}");
   Console.WriteLine($"{_state}");
   Console.WriteLine($"{_country}");
  }

}