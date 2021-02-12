using System;
using System.Collections.Generic;

namespace Koleksiypmlar
{
    class Program
    {
        static void Main(string[] args)
        {
            // toplu yoruma almak için conrol+K+c yorumu kaldırmak için control+k+U ya da üstteki tuş
            //string[] isimler = new string[] { "engin", "zelal", "başak", "cemal" };
            //Console.WriteLine(isimler[0]);
            //Console.WriteLine(isimler[1]);
            //Console.WriteLine(isimler[2]);
            //Console.WriteLine(isimler[3]);

            //isimler = new string[5];
            //isimler[4] = "İlker";
            //Console.WriteLine(isimler[4]);
            //Console.WriteLine(isimler[0]);

            List<string> isimler2 = new List<string> { "Engin", "Zelal", "Başak", "Cemal" };
            Console.WriteLine(isimler2[0]);
            Console.WriteLine(isimler2[1]);
            Console.WriteLine(isimler2[2]);
            Console.WriteLine(isimler2[3]);
            isimler2.Add("İlker");
            Console.WriteLine(isimler2[4]);
            Console.WriteLine(isimler2[0]);



        }
    }
}
