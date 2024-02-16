



//Constructor bir class new(); lendigi zaman çalışan bloktur (Yapıcı bloklar)  



Customer customer1 = new Customer { Id = 1, Name = "Alp Eren", LastName = "ÇELEBİ", City = "Kırşehir" };//burada new() ile degerler atanmıs


Customer customer2 = new(2,"Yağız Alp","ÇELEBİ","Mersin"); // burada ise overloading constructor ile degerler atanmıs

//İKİ KULLANIM DA YAPILABİLİR 2 ADET CONSTRUCTOR KULLANILDIĞI İÇİN ANCAK SÜSLÜ PARANTEZE DİKKAT EDELİM İLKİNDE SÜSLÜ PARANTEZ VAR
//İKİNCİ ÖRNEKTE İSE METHOD GİBİ KULLANILMIS İLKİ NORMAL OBJE TANIMLAR GİBİ İKİNCİSİ İSE PARAMETRELİ CONSTRUCTOR DAN FAYDALANILARAK YAPILMIS
// YANİ İLK ÖRNEKTE DEFAULT CONSTRUCTOR CALISTIRILMIS YANİ PARAMETRE OLMAYAN CONSTRUCTOR
    
Console.WriteLine(customer2.Name);
Console.WriteLine(customer1.Name);

class Customer
{
    public Customer() //constructor
    {
        
    }
    public Customer(int İd, string name, string lastName, string city) //overloading constructor
    {
        Id = İd;
        Name = name;
        LastName = lastName;
        City = city;
    }
    public int Id { get; set; }

    public string Name { get; set; }

    public string LastName { get; set; }

    public string City { get; set; }


}