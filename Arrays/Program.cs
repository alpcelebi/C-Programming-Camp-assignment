

//DİZİLER

//string[] students = new string [3];

//students[0] = "Alp Eren";
//students[1] = "Yağız Alp";
//students[2] = "Tuğçe";

//foreach (var student in students)
//{
//    Console.WriteLine(student);
//}



string[] students2 =  { "TUGCE", "YAGIZ", "ALP" };

foreach (var student2 in students2)
{
    Console.WriteLine(student2);
}



//COK BOYUTLU DİZİLER


string[,] sehirBolge = new string[3, 3]
{
    {"Ankara", "Adana","Mersin"},
    {"Diyarbakır", "Yozgat","Malatya"},
    {"Şanlıurfa", "Kocaeli","Bilecik"}



};


for (int i = 0; i <= sehirBolge.GetUpperBound(0); i++)
{
    for (int j =0; j<=sehirBolge.GetUpperBound(1); j++)
    {
        Console.WriteLine(sehirBolge[i, j]);
    }

    Console.WriteLine("***********");
}