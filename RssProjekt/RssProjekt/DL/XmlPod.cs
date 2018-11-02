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

    //"..\\xmlpodcasttest.xml"
    class XmlPod
    {
        //string path = "testaXml.xml";
        //Ändra så att path stämmer
        string path = "..\\xmlpodcasttest.xml";
        public void ifItExists(List<Podcast> listOfPodcasts)
        {
            
            if (!File.Exists(path))
            {
                //FileStream fs = new FileStream("..\\xmlpodcasttest.xml", FileMode.CreateNew, FileAccess.ReadWrite);
                using (Stream fs = new FileStream(path,
               FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                    serializer.Serialize(fs, listOfPodcasts);

                }
            }
            else
            {
                MessageBox.Show("It exists");
            }
        }

        public void addPodToXml(List<Podcast> listOfPodcasts)
        {
            using (Stream fs = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                serializer.Serialize(fs, listOfPodcasts);

            }
        }

        public List<Podcast> loadSavedPods(List<Podcast> listOfPodcasts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));

            using (FileStream fs = File.OpenRead(path))
            {
                listOfPodcasts = (List<Podcast>)serializer.Deserialize(fs);
            }
            return listOfPodcasts;
        }
    }
}
