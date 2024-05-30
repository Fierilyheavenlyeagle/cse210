public class Order
{
public List<Product> Products;
public Customer customer; 
private double totalCost;

public double productQuantity; 

 public double ProductQuantity()
  {
    foreach (Product product in Products)
    {
      productQuantity = productQuantity+ product.productQuantity;
    }
    return productQuantity;
  }

public void ShippingCost()
{
  productQuantity = ProductQuantity();
  customer.ForeignorNot();
  if (customer.Foreign == true)
  {
     totalCost = 35*productQuantity;
  }
  else if (customer.Foreign == false)
  {
    totalCost = 5*productQuantity;
  }

  Console.WriteLine($"Shipping Cost: ${totalCost}");

}

public void PackingLabel()
{
foreach (Product product in Products)
{
  Console.WriteLine($"Product Name: {product.productName}");
  Console.WriteLine($"Id : {product.productId}");
}
}
public void ShippingLabel()
{
  Console.WriteLine($"Client: {customer.personName}");
  Console.WriteLine("Address:");
  Address AddressDescription = customer.address;
  AddressDescription.AdressDescription();
}


}