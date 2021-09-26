using System;
using System.Collections.Generic;



namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var mylist = new MyList<string>();
            mylist.myAdd("Toyota");
            mylist.myAdd("Porsche");
            mylist.myAdd("Opel");
            mylist.myAdd("Merssedes");
            for (int i = 0; i < mylist.length; i++)
            {
                Console.WriteLine(mylist[i]);
            }
            Console.WriteLine($"Длина: {mylist.length}");
            Console.WriteLine($"Вызов по индексу: {mylist[3]}");

        }
    }
    class MyList<T> 
    {
        public T[] Array1 = new T[0];
        public void myAdd(T el)
        {
            Array.Resize(ref Array1, Array1.Length + 1);
            Array1[Array1.Length - 1] = el;
        }
        public T this[int index]
        {
            set { Array1[index] = value; }
            get { return Array1[index]; }
        }
        public int length
        {
            get { return Array1.Length; }
        }
    }
}
