using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;

namespace RssProjekt.DL
{

    class XmlKategori
    {
        XmlDocument doc = new XmlDocument();
        string path = @"XMLKategori.xml";
        public void ifItExists(List<string> katLista)
        {

            if (!File.Exists(path))
            {
                //FileStream fs = new FileStream("..\\xmlpodcasttest.xml", FileMode.CreateNew, FileAccess.ReadWrite);
                using (Stream fs = new FileStream(path,
               FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                    serializer.Serialize(fs, katLista);

                }
            }
            else
            {
                // MessageBox.Show("It exists");
            }
        }

        public void AddKategoriToXml (List<string> katLista)
        {
            //Directory.CreateDirectory(katNamn);
            using (Stream fs = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                serializer.Serialize(fs, katLista);

            }
        }
        public List<string> LoadSavedKats(List<string> katLista)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

            using (FileStream fs = File.OpenRead(path))
            {
                katLista = (List<string>)serializer.Deserialize(fs);
            }
            return katLista;

        }

    }
}
