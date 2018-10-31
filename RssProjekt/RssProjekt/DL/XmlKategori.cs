using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;



namespace RssProjekt.DL
{

    class XmlKategori
    {
         public void CreateXml()
        {
            XmlDocument doc = new XmlDocument();
            string path = @"XMLKategori.xml";
            XmlWriter xmlOut = XmlWriter.Create(path);
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Product");
            xmlOut.WriteString("Test");
            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();

            xmlOut.Flush();
            xmlOut.Close();
        }
        public void AddKategoriToXml (string katNamn)
        {

        }
    }
}
