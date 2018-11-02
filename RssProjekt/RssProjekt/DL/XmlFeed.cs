using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.IO;
using System.Xml.Serialization;

namespace RssProjekt.DL
{
    class XmlFeed
    {
        //använd denna genom att sätta lista = metoden. Namnsätt lista efter podID, så blir pod kopplat till feed
        //Måste köra en metod som ser till att det är en url som skickas in
        public List<Feed> makeFeed(string rssUrl)
        {
            List<Feed> listOfFeed = new List<Feed>();
            XmlReader reader = XmlReader.Create(rssUrl);
            var syndicationFeed = SyndicationFeed.Load(reader);
            foreach(var item in syndicationFeed.Items)
            {
                Feed feed = new Feed();
                feed.Title = item.Title.Text;
                feed.Description = item.Summary.Text;
                //feed.PodId = podId;
                listOfFeed.Add(feed);
            }
            return listOfFeed;
        }

        
        //Gör en mapp för varje feed. Mappnamn ska vara podId
        public void addMappForFeed (string mappNamn)
        {
            Directory.CreateDirectory("Feed//" + mappNamn);
        }

        public void AddFeedToXml(List<Feed> listOfFeed, string mapp)
        {
            string path = "Feed//" + mapp + "/feed.xml";
            using (Stream fs = new FileStream(path,
                FileMode.Create, FileAccess.Write, FileShare.None))
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>));
                serializer.Serialize(fs, listOfFeed);

            }
        }
    }
}
