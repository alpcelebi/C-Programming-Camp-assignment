

//Generic listeler aslında arkada array döndürürler




List<string> sehirler1 = new List<string>();

sehirler1.Add("Şanlıurfa");

 MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Kırşehir");

// genericlerde <buraya> hangi tipi verirseniz o tiple calısmak zorundasınız


// <T> bu T isimlendirmedir Type dan gelir
//MyList isimli generic listi Kullanırken <T> yerine hangi tipi verirsek o şekilde kullanabiliriz 
 class MyList <T>  // GENERİC CLASS 
{
    T[] _array;
    T[] _tempArray;
    public MyList()
    {
        _array = new T[0];  
    }

    public void Add(T item) { 

        _tempArray= _array;
    
        _array= new T[_array.Length+1];

        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }

        _array[_array.Length - 1] = item;
    }


    private int _count;

    public int Count
    {
        get { return _array.Length; }
        
    }

}