using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;

namespace RssProjekt.DL
{
    class XmlFeed
    {
        //använd denna genom att sätta lista = metoden. Namnsätt lista efter podID, så blir pod kopplat till feed
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
                listOfFeed.Add(feed);
            }
            return listOfFeed;
        }
    }
}
