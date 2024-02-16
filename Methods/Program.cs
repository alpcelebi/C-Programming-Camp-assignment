



//static void Add()
//{

//    Console.WriteLine("Added");

//}

//Add();


//static int Add2(int num1,int num2)
//{
//    int result= num1 + num2;

//    return result;

//    Console.WriteLine(result);

//}


//var result = Add2(20, 30);

//Console.WriteLine(result);  


// ref keywordü deger tipi referans tip olarak kullanılmasını saglar eger deger verilmemişse out kullanılır


//Method overloading
//



//static int Carpma (int number1,int number2,int number3)
//{
//    return number1 * number2*number3;

//}

//Console.WriteLine(Carpma(12, 122,13));


//params

static int Add4(params int[]numbers )
{
    return numbers.Sum();
}

Console.WriteLine(Add4(3,4,5,6,7,78));