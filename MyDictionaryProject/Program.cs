using System;
using System.Collections.Generic;

namespace MyDictionaryProject
{
    class Program
    {
        static void Main(string[] args)
        {
            MyDictionary<int, string> users = new MyDictionaryProject.MyDictionary<int,string>();
            users.Add(1,"OzlemT");
            users.Add(2, "AyseK");

            Console.WriteLine("Kullanıcı sayısı:" + users.Count);

            Console.WriteLine("Kullanıcı Listesi");
            users.Listele();

        }
    }
}
