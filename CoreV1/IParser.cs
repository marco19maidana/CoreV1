using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoreV1
{
    public interface IParser
    {
        void SpeichereKunde(Kunde kunde);
        List<Kunde> LadeKunde(String path);
        void SpeichereBuch(List<Buch> books);
            List<Buch> LadeBuch(string path2);
        //Kunde LadeKunde(String path);
    }
}
