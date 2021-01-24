using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            #region ArrayList

            //ArrayList araclar = new ArrayList();
            //araclar.Add("26 ABC 123");
            //araclar.Add("26 BCD 456");
            //araclar.Add("34 EFG 223");

            //for (int i = 0; i < araclar.Count; i++)
            //{
            //    Console.WriteLine(araclar[i]);
            //}

            #endregion

            #region List

            //List<string> araclar = new List<string>();
            //araclar.Add("26 ABC 123");
            //araclar.Add("26 BCD 456");
            //araclar.Add("34 EFG 223");

            //for (int i = 0; i < araclar.Count; i++)
            //{
            //    Console.WriteLine(araclar[i]);
            //}

            #endregion


            Hashtable araclar = new Hashtable();
           
            araclar.Add("26 ACD 456", "Tuğba Çalışkan");
            araclar.Add("26 ABC 123", "Deniz Gören");
            araclar.Add("34 EFG 223", "Ahmet Doğan");

            #region Hashtable

            //araclar.Add("34 EFG 223", "Ahmet Doğan");
            //Key değerleri unique(eşsiz) olmalıdır.

            //if (araclar.ContainsKey("26 ABC 123"))
            //{
            //    Console.WriteLine(araclar["26 ABC 123"]);
            //}
            //else
            //{
            //    Console.WriteLine("Araç bulunamadı");
            //}

            //if (araclar.ContainsValue("Tuğba Çalışkan"))
            //{
            //    Console.WriteLine(araclar["26 ACD 456"]);
            //}
            //else
            //{
            //    Console.WriteLine("Mevcut değil");
            //}

            #endregion

            #region Hastable Listeleme

            //ArrayList aracplaka = new ArrayList(araclar.Keys);

            //foreach (object item in aracplaka)
            //{
            //    Console.WriteLine(item);
            //}

            //ArrayList aracsurucu = new ArrayList(araclar.Values);

            //foreach (object item in aracsurucu)
            //{
            //    Console.WriteLine(item);
            //}

            //ICollection aracPlaka2 = araclar.Keys;

            //foreach (object item in aracPlaka2)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region HashTable Listeleme 2

            //ArrayList plakalar = new ArrayList(araclar.Keys);
            //ArrayList suruculer = new ArrayList(araclar.Values);

            //for (int i = 0; i < plakalar.Count; i++)
            //{
            //    Console.WriteLine($"Plaka = {plakalar[i]}, Sürücü = {suruculer[i]}");
            //}

            #endregion

            #region Hashtable Listeleme 3

            foreach (DictionaryEntry item in araclar)
            {
                Console.WriteLine(item.Key + " - " + item.Value);
            }

            #endregion
        }
    }
}
