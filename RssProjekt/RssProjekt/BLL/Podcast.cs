using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    class Podcast:ILists 
    {
        public string RssUrl { get; set; }
        public string Namn { get; set; }
        public string Kategori { get; set; }
        public string Uppdatering { get; set; }

        public List<string> MakeLVItem()
        {
            return new List<string> { RssUrl, Namn, Kategori, Uppdatering };
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

    }
}
