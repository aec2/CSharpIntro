﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> sehirler = new List<string>();
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");
            sehirler.Add("Ankara");


            sehirler[0] = "İstanbul"; //set
            //Console.WriteLine(sehirler[0]); //get
            //Console.WriteLine(sehirler.Count);


            MyList<string> sehirler2 = new MyList<string>();
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2.Add("Kayseri");
            sehirler2[0] = "İstanbul";
            //indexing

            foreach (var sehir in sehirler2.Items)
            {
                Console.WriteLine(sehir);
            }
            //Console.WriteLine(sehirler2.Count);
        }
    }

    // T Type'tan geliyor.
    class MyList<T> // Generic class
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

        public int Count
        {
            get { return _array.Length; }
        }

        public T[] Items
        {
            get
            {
                return _array;
            }
        }

        public T this[int index]
        {
            get
            {
                return _array[index];
            }

            set
            {
                _array[index] = value;
            }
        }

    }
}
