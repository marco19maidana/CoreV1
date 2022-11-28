using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1
{
    public class Kunde
    {
        #region Felder
        private string _vorname;
        private string _nachname;
        private int _kundenID;
        private string _kundenNr;
        #endregion

        #region Eigenschaften
        public string Vorname { 
            get { return _vorname; }
            set { _vorname = value; } }

        public string Nachname
        {
            get { return _nachname; }
            set { _nachname = value; }
        }

        public int KundenID
        {
            get { return _kundenID; }
            set { _kundenID = value; }
        }

        public string KundenNr
        {
            get { return _kundenNr; }
            set { _kundenNr = value; }
        }

        #endregion

        public Kunde() { }
    }
}
