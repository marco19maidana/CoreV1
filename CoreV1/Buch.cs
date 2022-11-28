using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1
{
    public class Buch
    {
        #region Felder
        private string _iSBN;
        private string _autor;
        private string _verlag;
        #endregion

        #region Eigenschaften
        public string ISBN
        {
            get{ return _iSBN; }
            set{ _iSBN = value; }
        }
        public string Autor { 
            get{ return _autor; }
            set{ _autor = value; }
        }
        public string Verlag
        {
            get{ return _verlag; }
            set{ _verlag = value; }
        }
        #endregion
    }
}
