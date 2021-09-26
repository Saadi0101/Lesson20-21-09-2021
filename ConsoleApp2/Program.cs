using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            var myDic = new MyDictionary<string, string>();
            myDic.myAdd("1", "11");
            myDic.myAdd("2", "22");
            myDic.myAdd("3", "33");
            myDic.myAdd("4", "44");
            myDic.myAdd("5", "55");
            for (int i = 0; i < myDic.length; i++)
            {
                Console.WriteLine(myDic[i]);
            }
            Console.WriteLine($"Вызов по индексатору: {myDic[4]}");
            Console.WriteLine($"Длина: {myDic.length}");
        }
    }
    class MyDictionary<T, U>
    {
        public T[] arr = new T[0];
        public U[] arr2 = new U[0];
        public string[] arr3 = new string[0];
        public void myAdd(T key, U value)
        {
            Array.Resize(ref arr, arr.Length + 1);
            Array.Resize(ref arr2, arr2.Length + 1);
            Array.Resize(ref arr3, arr3.Length + 1);
            arr[arr.Length - 1] = key;
            arr2[arr2.Length - 1] = value;
            arr3[arr2.Length - 1] = arr[arr.Length - 1] + "-" + arr2[arr2.Length - 1];
            
        }        
        public  string this[int index]
        {
            set { myAdd(arr[index], arr2[index]); }
            get { return arr3[index]; }
        }
        public int length
        {
            get { return arr.Length; }
        }
    }
}
