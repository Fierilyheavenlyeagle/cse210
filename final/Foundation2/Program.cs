using System;

class Program
{
    static void Main(string[] args)
    {
        Order order1 = new Order
        {
            customer = new Customer
            {
                personName = "Alvaro Cerpa Barón",
                address = new Address("Av.Santa Gertrudis 308" , "Lima", "Lima", "Perú")
            },
            Products = new List<Product>
            {
                new Product { productName = "iPhone 13", productId = "20240502123", price = 3000, productQuantity = 5},

                new Product { productName = "Tablet Huawei Tab 13", productId = "20240502124", price = 2000, productQuantity = 4
                },

                 new Product { productName = "MacBook Air", productId = "20240502125", price = 4000, productQuantity = 2
                }
            }


        };


        Order order2 = new Order
        {
            customer = new Customer
            {
                personName = "Jimena Hernandez Casimiro",
                address = new Address("20 Cooper Square", "New York", "NY 10003", "USA")  
            },
            Products = new List<Product>
            {
                new Product { productName = "iPhone 14 Pro", productId ="20240503456",price=4000,productQuantity=3},
                new Product { productName="Instant Pot Duo 7-in-1 Electric Pressure Cooker",productId="20240503457",price=2000,productQuantity=4},
                new Product { productName="Bose Noise Cancelling Headphones 700",productId="20240503458", price =1000
                , productQuantity=1}
            }
        };

        order1.PackingLabel();
        order1.ShippingLabel();
        order1.ShippingCost();

        order2.PackingLabel();
        order2.ShippingLabel();
        order2.ShippingCost();
    }
}