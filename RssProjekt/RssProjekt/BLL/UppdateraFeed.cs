using RssProjekt.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    public class UppdateraFeed
    {
        XmlFeed xmlFeed = new XmlFeed();


       
        public bool CheckIfUpdated(string podId, string url)
        {
            var feedToCheck = xmlFeed.LoadSavedFeeds(podId);
            var newestFeed = xmlFeed.makeFeed(url);

            string oldTitle = feedToCheck[0].Title;
            string newTitle = newestFeed[0].Title;
            if(!oldTitle.Equals(newTitle))
            {
               
                return true;
            }
            else
            {
                return false;
            }

        }

    }
}
