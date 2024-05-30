public class Product
{
  public string productName;
  public string productId;
  public double price;
  public double productQuantity;

  private double cost;

   public void ProductCost(double price1, double productQuantity1 )
  {
    price = price1;
    productQuantity = productQuantity1;
    cost = price * productQuantity;
  }

}