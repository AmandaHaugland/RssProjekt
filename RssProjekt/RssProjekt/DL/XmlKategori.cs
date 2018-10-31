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
        public void CreateXml()
        {
            //XmlDocument doc = new XmlDocument();
           
            XmlWriter xmlOut = XmlWriter.Create(path);
            xmlOut.WriteStartDocument();
            xmlOut.WriteStartElement("Kategorier");
                //xmlOut.WriteStartElement("Podcast");
                  //   xmlOut.WriteElementString("PodName", "name of pod");
                // xmlOut.WriteEndElement();

            xmlOut.WriteEndElement();
            xmlOut.WriteEndDocument();

           
            xmlOut.Close();
        }
        public void AddKategoriToXml (string katNamn)
        {
            XDocument doc = XDocument.Load(path);
            XElement root = new XElement("Kategori", katNamn);
           // root.Add(new XAttribute("name", "name goes here"));
            //root.Add(new XElement("Kategorinamn", katNamn));
            doc.Element("Kategorier").Add(root);
            doc.Save(path);
        }
    }
}
