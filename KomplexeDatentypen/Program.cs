using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KomplexeDatentypen
{
    class Program
    {
        static void Main(string[] args)
        {
            // Arrays
            //int[] zahlen = new int[5];
            //zahlen[0] = 12;
            // ....


            #region List<T>
            //List<int> zahlenListe = new List<int>();

            //zahlenListe.Add(9);
            //zahlenListe.Add(500);
            //zahlenListe.Add(77);
            //zahlenListe.Add(12);
            //zahlenListe.Add(3);

            //zahlenListe.Sort();

            //foreach (var item in zahlenListe)
            //{
            //    Console.WriteLine(item);
            //} 
            #endregion

            #region Stack<T>  - LIFO
            //Stack<string> meineTexte = new Stack<string>();

            //meineTexte.Push("Hallo");
            //meineTexte.Push("Welt");
            //meineTexte.Push("!");

            //Console.WriteLine(meineTexte.Pop());
            //Console.WriteLine(meineTexte.Pop());
            //Console.WriteLine(meineTexte.Pop()); 
            #endregion

            #region Queue<T> - FIFO
            //Queue<int> meineQueue = new Queue<int>();

            //meineQueue.Enqueue(12);
            //meineQueue.Enqueue(4);
            //meineQueue.Enqueue(7);

            //Console.WriteLine(meineQueue.Dequeue());
            //Console.WriteLine(meineQueue.Dequeue());
            //Console.WriteLine(meineQueue.Dequeue()); 
            #endregion

            #region Dictionary<TKey,TValue>
            //Dictionary<string, string> Länder = new Dictionary<string, string>();

            //Länder.Add("Österreich", "Wien");
            //Länder.Add("Ungarn", "Budapest");
            //Länder.Add("Slowenien", "Laibach");
            //Länder.Add("Slowakei", "Pressburg");
            //Länder.Add("Tschechei", "Prag");
            //Länder.Add("Deutschland", "Berlin");
            //Länder.Add("Frankreich", "Paris");
            //Länder.Add("Spanien", "Madrid");

            //if(Länder.ContainsKey("England"))
            //    Console.WriteLine(Länder["England"]);
            //else
            //    Console.WriteLine("Nicht mehr in der EU"); 
            #endregion

a

            Console.WriteLine("---ENDE---");
            Console.ReadKey();
        }
    }
}
