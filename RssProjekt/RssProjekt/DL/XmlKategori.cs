using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;

namespace RssProjekt.DL
{

    class XmlKategori
    {
        XmlDocument doc = new XmlDocument();
        string path = @"../XMLKategori.xml";
        
        public void AddKategoriToXml (string katNamn)
        {
            Directory.CreateDirectory(katNamn);
        }
    }
}
