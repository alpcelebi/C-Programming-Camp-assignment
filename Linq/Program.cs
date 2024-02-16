




List <Category> categories= new List<Category> { 

    new Category {CategoryId=1,CategoryName="Bilgisayar"},
     new Category {CategoryId=2,CategoryName="Telefon"}


};

List<Product> products = new List<Product> { 

     new Product{ProductId=1,ProductName="Acer Bilgisayar", CategoryId=1, QentityPerUnit="32 Gb RAM", UnitPricce=10000, UnitsInStock=12},
     new Product{ProductId=2,ProductName="Hp Bilgisayar", CategoryId=1, QentityPerUnit="16 Gb RAM", UnitPricce=8000, UnitsInStock=11},
     new Product{ProductId=3,ProductName="Monster Bilgisayar", CategoryId=1, QentityPerUnit="32 Gb RAM", UnitPricce=6000, UnitsInStock=2},
     new Product{ProductId=4,ProductName="Apple ", CategoryId=2, QentityPerUnit="8 Gb RAM", UnitPricce=5000, UnitsInStock=3},
     new Product{ProductId=5,ProductName="Samsung ", CategoryId=2, QentityPerUnit="8 Gb RAM", UnitPricce=4000, UnitsInStock=20}



};

//ürünlerde böyle filtrelemeler kullanılabilir ancak işler karmasık bir hal alır
//foreach (var product in products)
//{
//    if (product.UnitPricce>=5000)
//    {
//        Console.WriteLine(product.ProductName);
//    }
//}

//static List<Product> GetProducts()
//{


//}

//LİNQ VERİ TABANI KODLARIMIZI C# İLE KULLANMAMIZI SAGLAR

var result = products.Where(p => p.UnitPricce >= 5000 && p.UnitsInStock > 2).ToList();

foreach (var product in result)
{
    Console.WriteLine(product.ProductName);
}





class Product
{


    public int ProductId { get; set; }

    public int CategoryId { get; set; }
    public string ProductName { get; set; }


    public string QentityPerUnit { get; set; }

    public decimal UnitPricce { get; set; }

    public int UnitsInStock { get; set; }


}


class Category
{

    public int CategoryId { get; set; }

    public string CategoryName { get; set; }



}