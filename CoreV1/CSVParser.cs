using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace CoreV1
{
    public class CSVParser : IParser
    {
        public static string path = @"C:\prog\Kunden.csv";
        static string path2 = @"C:\prog\Buecher.csv";
        static char trennzeichen = ';';
        public List<Kunde> LadeKunde(string path)
        {
            List<Kunde> t_kunden = new List<Kunde>();
            string[] zeilen, felder;
            Kunde t_kunde;
            try
            {
                zeilen = File.ReadAllLines(path);
                foreach (var zeile in zeilen)
                {
                    felder = zeile.Split(trennzeichen);
                    t_kunde = new Kunde();
                    {
                        t_kunde.Vorname = felder[0];
                        t_kunde.Nachname = felder[1];
                        t_kunde.KundenID = Convert.ToInt32(felder[2]);
                        t_kunde.KundenNr = felder[3];
                    }
                }
                return t_kunden;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public List<Buch> LadeBuch(string path2)
        {
            List<Buch> books = new List<Buch>();
            string[] zeilen, felder;
            Buch t_buch;
            try
            {
                zeilen = File.ReadAllLines(path2);
                foreach (var zeile in zeilen)
                {
                    felder = zeile.Split(trennzeichen);
                    t_buch = new Buch();
                    {
                        t_buch.ISBN = felder[0];
                        t_buch.Autor = felder[1];
                        t_buch.Verlag = felder[2];
                    }
                }
                return books;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SpeichereKunde(Kunde kunde)
        {
            string[] zeilen = new string[1];
            zeilen[0] = kunde.Vorname + trennzeichen +
                kunde.Nachname + trennzeichen +
                kunde.KundenNr + trennzeichen +
                kunde.KundenNr;
            try
            {
                File.AppendAllLines(path, zeilen);
            }
            catch (Exception)
            {
                throw;
            }
        }

        public void SpeichereBuch(List<Buch> books)
        {
            string[] zeilen = new string[books.Count];
            for (int i=0;i<books.Count; i++)
            {
                zeilen[i] = books[i].ISBN + trennzeichen + books[i].Autor + trennzeichen + books[i].Verlag;
            }
            try
            {
                File.WriteAllLines(path2, zeilen);
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}
