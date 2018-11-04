using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    public class MethodListView
    {
        public virtual List<string> MakeLVItem(string id, string rssUrl, string namn, string avsnitt, string kategori, string uppdatering)
        {
            return new List<string> { id, rssUrl, namn, avsnitt, kategori, uppdatering };
        }

        public virtual ListViewItem MakeListView(string id, string rssUrl, string namn, string avsnitt, string kategori, string uppdatering)
        {
            return new ListViewItem(MakeLVItem(id, rssUrl, namn, avsnitt, kategori, uppdatering).ToArray());
        }

        public virtual List<string> MakeLVItem (string title)
        {
            return new List<string> { title };
        }

        public virtual ListViewItem MakeListView(string title)
        {
            return new ListViewItem(MakeLVItem(title).ToArray());
        }
    }
}
