using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.IO;
using System.Xml.Linq;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace RssProjekt.DL
{

    class XmlKategori
    {
        XmlDocument doc = new XmlDocument();
        string path = @"XMLKategori.xml";
        public void ifItExists(List<string> katLista)
        {
            try
            {
                if (!File.Exists(path))
                {

                    using (Stream fs = new FileStream(path,
                   FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                        serializer.Serialize(fs, katLista);

                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("Felmeddelande : " + e.Message);
            }
           
        }

        public void AddKategoriToXml (List<string> katLista)
        {
            try
            {
                using (Stream fs = new FileStream(path,
                    FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<string>));
                    serializer.Serialize(fs, katLista);

                }
            }catch(Exception e)
            {
                MessageBox.Show("Felmeddelande: " + e.Message);
            }
        }
        public List<string> LoadSavedKats(List<string> katLista)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<string>));

                using (FileStream fs = File.OpenRead(path))
                {
                    katLista = (List<string>)serializer.Deserialize(fs);
                }
            } catch(Exception e)
            {
                MessageBox.Show("Felmeddelande: " + e.Message);
            }
            return katLista;

        }

    }
}
