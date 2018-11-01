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
    class Podcast: ISerializable 
    {
        public string RssUrl { get; set; }
        public string Namn { get; set; }
        public string Kategori { get; set; }
        public string Uppdatering { get; set; }
        public int PodId { get; set; }
        public int Avsnitt { get; set; }

        public Podcast() { }
        //Ska ha metod för att sätta antal avsnitt

        public List<string> MakeLVItem()
        {
            return new List<string> { RssUrl, Namn, Avsnitt.ToString(), Kategori, Uppdatering };
        }
        public int MakeId()
        {
            //Metoden ska kolla ta emot antalet ´poddar och jobba utifrån det...
     return 0;
       }


        public ListViewItem MakeListView()
        {
            return new ListViewItem(MakeLVItem().ToArray());
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
