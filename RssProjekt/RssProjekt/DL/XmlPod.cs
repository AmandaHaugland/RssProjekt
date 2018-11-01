using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace RssProjekt.DL
{
    class XmlPod
    {
        public void addPodToXml(List<Podcast> listOfPodcasts)
        {
            using (Stream fs = new FileStream("..\\xmlpodcasttest.xml",
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));
                serializer.Serialize(fs, listOfPodcasts);

            }
        }

        public void loadSavedPods(List<Podcast> listOfPodcasts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));

            using (FileStream fs = File.OpenRead("..\\xmlpodcasttest.xml"))
            {
                listOfPodcasts = (List<Podcast>)serializer.Deserialize(fs);
            }
        }
    }
}
