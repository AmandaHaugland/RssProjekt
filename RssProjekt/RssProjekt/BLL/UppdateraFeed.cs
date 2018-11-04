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


        //Kanske göra om till en void?? Som bara kör metod för att uppdatera
        public bool CheckIfUpdated(string podId, string url)
        {
            var feedToCheck = xmlFeed.LoadSavedFeeds(podId);
            var newestFeed = xmlFeed.makeFeed(url);

            string oldTitle = feedToCheck[0].Title;
            string newTitle = newestFeed[0].Title;
            if(!oldTitle.Equals(newTitle))
            {
                //De är INTE likadana
                return true;
            }
            else
            {
                return false;
            }

        }

        //En metod som tar in url, id och uppdatering

       // public void UpdateTimer(string uppd)
       // {
       //     System.Timers.Timer timer = new System.Timers.Timer(10000);
       //     timer.Elapsed += (sender, e)=>{ OnTimedEvent(uppd); };
       //     timer.Enabled = true;
       // }
       //
       //
       // private static void OnTimedEvent(string uppd)
       // {
       //     
       //     MessageBox.Show("Testar: " + uppd);
       //     FeedDictionary = xmlFeed.LoadDirectory(Podcasts)
       //
       // }
    }
}
