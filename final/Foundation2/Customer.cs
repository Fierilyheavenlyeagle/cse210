public class Customer 
{
  public string personName;
  public Address address;

  public bool Foreign; 

  public void ForeignorNot()
  {
    if (address._country == "USA" || address._country == "united states" || address._country == "United States")
    {
     Foreign = false;
    }
    else 
    {
      Foreign = true;
    }
  }


}