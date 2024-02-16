


////int decimal float longn bool enum değer tiplerdir (Value Types)


//int sayi1 = 10;
//int sayi2 = 20;

// sayi1 = sayi2;


//sayi2 = 100;

//Console.WriteLine(sayi1);



////Arrays Class ve İnterfaceler referance typesdır
//int[] sayilar1 = new int[] { 1,2,3,4,5} ;

//int[] sayilar2 = new int[] { 10, 20, 30, 40, 50 };

//sayilar2 = sayilar1;

//sayilar2[0] = 1000;

//Console.WriteLine(sayilar1[0]);




Person person1 = new Person();
Person person2 = new Person();

person1.FirstName = "Alp";

person2 = person1;

person1.FirstName = "Yağız Alp";

Console.WriteLine(person2.FirstName);






Customer customer = new Customer();

customer.FirstName = "Tuğçe";
customer.CreditCardNumber = "123123123";

Employeee employeee = new Employeee();
employeee.FirstName = "Alp Eren";

Person person3 = customer;

Console.WriteLine(person3.FirstName);
Console.WriteLine(((Customer)person3).CreditCardNumber);


//Miras alınan sınıfın değerleri allınabilir yani Base sınıfın değerleri inherit eden sınıfların referansı atanabilir yukarıda ki örnekte oldugu gibi
//Ancak ancak person isimli class da tanımlanan örneğin custemer içerisinde bulunan CreditCardNumber ulaşabilmek için

// örneign Console.Writline(((Customer)person3).CreditCardNumber); şeklinde ulaşılabilir parantezler öenmli !! :)
// Bu örnekte bulunan Customer bir tiptir yani int string gibi Customer tipinde oldugunu belirtiyoruz



PersonManager personManager = new();

personManager.Add(customer);

class Person
{

    public int Id { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }
}


class Customer : Person
{
    public string CreditCardNumber { get; set; }


}


class Employeee : Person
{

    public int EmployeeNumber { get; set; }
}


class PersonManager
{

    public void Add(Person person)
    {

        Console.WriteLine(person.FirstName);
    }
}

