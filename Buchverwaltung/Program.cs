using CoreV1;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace Buchverwaltung
{
    public class Program
    {
        static string _path = @"C:\prog\Kunden.csv";
        static string path2 = @"C:\prog\Buecher.csv";
        static List<Kunde> clients = new List<Kunde>();
        static List<Buch> books = new List<Buch>();
        static CSVParser IParser = new CSVParser();
        static void Main(string[] args)
        {
            //CSVParser myParser = new CSVParser();
            IParser myParser = new CSVParser();
            List<Kunde> kunden;
            kunden = myParser.LadeKunde(_path);
            foreach (var kunde in kunden)
            {
                Console.WriteLine("{0},{1},{2},{3}", kunde.Vorname, kunde.Nachname, kunde.KundenID, kunde.KundenNr);
                Console.ReadLine();
            }
            NeuerKunde();
            NeuesBuch();
            books=myParser.LadeBuch(path2);
            myParser.SpeichereBuch(books);
        }
        public static void NeuerKunde()
        {
            //CSVParser IParser = new CSVParser();
            Kunde t_client = new Kunde();
            Console.Write("Kundenvorname: ");
            t_client.Vorname = Console.ReadLine();
            Console.Write("Kundennachname: ");
            t_client.Nachname = Console.ReadLine();
            Console.Write("KundenNr");
            t_client.KundenNr = Console.ReadLine();
            Console.Write("KundenID: ");
            t_client.KundenID = Convert.ToInt32(Console.ReadLine());
            clients.Add(t_client);
            IParser.SpeichereKunde(t_client); //IParser ist static
        }

        public static void NeuesBuch()
        {
            //CSVParser IParser = new CSVParser();
            Buch t_buch = new Buch();
            Console.Write("Autorname: ");
            t_buch.Autor = Console.ReadLine();
            Console.Write("Verlag: ");
            t_buch.Verlag = Console.ReadLine();
            Console.Write("ISBN");
            t_buch.ISBN = Console.ReadLine();
            books.Add(t_buch);
            IParser.SpeichereBuch(books); //IParser ist static
        }
    }
}
