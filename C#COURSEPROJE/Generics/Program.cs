List<string> sehirler = new List<string>();
//T hangi tipi verirsem o tipe göre çalıimamı sağlar
MyList<string> sehirler2 = new MyList<string>();
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
sehirler2.Add("Ankara");
Console.WriteLine(sehirler2.Count);
class MyList<T>
{
    T[] _array;
    T[] _tempArray;

    public MyList()
    {
        _array = new T[0];
    }
    private int _count;

    public int Count
    {
        get { return _array.Length; }
       
    }


    public void Add(T item)
    {

        _tempArray =  _array;
        _array = new T[_array.Length+1];
        for (int i = 0; i < _tempArray.Length; i++)
        {
            _array[i] = _tempArray[i];
        }
        _array[_array.Length-1]= item;
    }
}