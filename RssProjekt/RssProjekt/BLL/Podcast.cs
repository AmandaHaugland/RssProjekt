using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    [Serializable()]
   public class Podcast: MethodListView, ISerializable 
    {
        public string RssUrl { get; set; }
        public string Namn { get; set; }
        public string Kategori { get; set; }
        public string Uppdatering { get; set; }
        public int PodId { get; set; }
        public int Avsnitt { get; set; }

        public Podcast() { }
       

        public int MakeId(List<Podcast> podList)
        {
            int lengthOfPodList = podList.Count;
            if (lengthOfPodList > 0) 
            {
                var lastInList = podList[lengthOfPodList - 1];
                return lastInList.PodId + 1;
            }
            else
            {
                return 0;
            }
     
       }


        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Namn", Namn);
            info.AddValue("RssUrl", RssUrl);
            info.AddValue("Uppdatering", Uppdatering);
            info.AddValue("PodId", PodId);

            //throw new NotImplementedException();
        }

        public Podcast(SerializationInfo info, StreamingContext context)
        {
            Namn = (string)info.GetValue("Namn", typeof(string));
            RssUrl = (string)info.GetValue("RssUrl", typeof(string));
            Uppdatering = (string)info.GetValue("Uppdatering", typeof(string));
            PodId = (int)info.GetValue("PodId", typeof(string));
        }
    }
}
