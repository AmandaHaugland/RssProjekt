using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.IO;


namespace RssProjekt.DL
{
    public class XmlPodcast
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

        public void loadSavedPods(List<XmlPodcast> listOfPodcasts)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Podcast>));

            using (FileStream fs = File.OpenRead("..\\xmlpodcasttest.xml"))
            {
                listOfPodcasts = (List<Podcast>)serializer.Deserialize(fs);
            }
        }
    }
}
