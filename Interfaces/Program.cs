//// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

////ÖNEMLİ NOT : INTERFACELERİN ASIL AMACI UYGULAMA İÇİ BAGIMLILIKLARI EN AZA İNDİRMEKTİR !!
/////interfaceler newlenemezzz!!!
///


//CustomerManager customerManager = new CustomerManager();

//customerManager.Add(new SqlServerDal());


using Interfaces;

ICustomerDal[] customerDals = new ICustomerDal[2]
 {
     new SqlServerDal(),

     new OracleServerDal()
 };

foreach (var customerDal in customerDals)
{
    customerDal.Add();
}

