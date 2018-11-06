using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace RssProjekt.DL
{

    
    class XmlPod
    {
       
        string path = "xmlPodcasts.xml";
        public void ifItExists(List<Podcast> listOfPodcasts)
        {
            try
            {
                if (!File.Exists(path))
                {
                    using (Stream fs = new FileStream(path,
                   FileMode.Create, FileAccess.Write, FileShare.None))
                    {
                        XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                        serializer.Serialize(fs, listOfPodcasts);

                    }
                }
            } catch(Exception e)
            {
                MessageBox.Show("Felmeddelande: " + e.Message);
            }
            
        }

        public void addPodToXml(List<Podcast> listOfPodcasts)
        {
            try
            {
                using (Stream fs = new FileStream(path,
                    FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                    serializer.Serialize(fs, listOfPodcasts);

                }
            } catch(Exception e)
            {
                MessageBox.Show("Felmeddelande: " + e.Message);
            }
        }

        public List<Podcast> loadSavedPods(List<Podcast> listOfPodcasts)
        {
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));

                using (FileStream fs = File.OpenRead(path))
                {
                    listOfPodcasts = (List<Podcast>)serializer.Deserialize(fs);
                }
            } catch(Exception e)
            {
                MessageBox.Show("Felmeddelande: " + e.Message);
            }
            return listOfPodcasts;
        }
    }
}
