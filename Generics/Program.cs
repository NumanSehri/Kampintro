using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {

            
            List<string> sehirler = new List<string>();
            sehirler.Add("Amasya");
            Console.WriteLine(sehirler.Count);

            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Suluova");
            sehirler2.Add("Suluova");
            sehirler2.Add("Suluova");
            sehirler2.Add("Suluova");
            sehirler2.Add("Suluova");
            Console.WriteLine(sehirler2.Count);
           
        }
    }

    class MyList<T>
    {
        T[] _array;
        T[] _tempArray;

        public MyList()
        {
            _array = new T[0];
        }
        
        public void Add(T item)
        {
            _tempArray = _array;
            _array = new T[_array.Length + 1];

            for (int i = 0; i < _tempArray.Length; i++)
            {
                _array[i] = _tempArray[i];
            }

            _array[_array.Length - 1] = item;

        }
        //Bu nedir ne işe yarar
        private int _count;

        public int Count
        {
            get { return _array.Length; }
            
        }

    }
}
