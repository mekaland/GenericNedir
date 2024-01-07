using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericNedir
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //bir datayı bir liste içerisinde tutucaksak ve bunu tabiki generic olarak tutmak isteriz
            // ve list genericleri yoğun olarak kullanılırız
            // listgeneric arraylistin generic versiyonu
          
            // <t>  t tip demek .net framwork içerisinde olan veya bizim oluşturduğumuz
            //  herhangi bir tip demek.
            List<int> list = new List<int>();
            list.Add(1);
            list.Add(2);
            for(int i = 0; i < list.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<string> isimler = new List<string>();
            isimler.Add("cengiz");
            isimler.Add("kadir");
            for (int i = 0; i < isimler.Count; i++)
            {
                Console.WriteLine(list[i]);
            }

            List<msuteri> msuteriListe = new List<msuteri>();
            msuteriListe.Add(new msuteri()
            {
                id = 1,
                isim = "cengiz",
                soyisim = "daglı"

            } );
            foreach( msuteri item in msuteriListe)
            {
                Console.WriteLine(item.isim);
            }
            Console.ReadLine();
        }
    }
}
