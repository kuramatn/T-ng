using System;
//using System.Text;

public class Product
{
    public  string name;
    public float price;
    public int quantity;

    public Product(string name, float price, int quantity)
    {
        this.name = name;
        this.price = price;
        this.quantity = quantity;
    }
}

public class Bill
{
    DateTime Present = DateTime.Now;
    public int TotalPrice;
  
    List<Product> productlist = new List<Product>();
   
        //List<string> myprice = new List<string>();
    public void AddProductList(Product inputProduct)
    {
       // Product prod = new Product("a", 1000, 3);
        productlist.Add(inputProduct);
    }
    public void PrintBill()
    {
        Console.WriteLine("Bill Release Date: " + Present);
        Console.WriteLine("Total Price: " + TotalPrice);
        Console.WriteLine("Products:");
        foreach (Product product in productlist)
        {
            Console.WriteLine("Name: " + product.name + ", Price: " + product.price + ", Quantity: " + product.quantity);
        }
    }
    public void calTotalPrice()
    {
        TotalPrice = 0;
        foreach (Product product in productlist)
        {
            TotalPrice += (int)(product.price* product.quantity);
        }
        //for use and sum

        //productlist

        //inputval
    }
}

public class inputdata
{
   
    public inputdata(string name, string aadress)
    {
        
       // Console.WriteLine("Enter your name: ");
       // name = Console.ReadLine();
       // Console.WriteLine("Enter your address: ");
       // aadress = Console.ReadLine();
        Console.WriteLine("Name: " +  name);
        Console.WriteLine("Address: " + aadress);
    }
    
}

class Program
{
   
    static void Main()
    {
        //Console.OutputEncoding = Encoding.UTF8;
 
        // Tạo một đối tượng ID
        inputdata person = new inputdata("Tung","Thai Nguyen");
        Bill bill = new Bill();
        Product product1 = new Product("Product 1", 3000, 3);
        Product product2 = new Product("Product 2", 2500, 2);
        bill.AddProductList(product1);
        bill.AddProductList(product2);
        bill.calTotalPrice();
        bill.PrintBill();
        

      // DateTime Present = DateTime.Now;
      //  Console.WriteLine("Realtime is: " + Present);


        Console.Read();  
    }
}
