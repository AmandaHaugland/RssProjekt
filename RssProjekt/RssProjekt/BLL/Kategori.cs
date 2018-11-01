using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    [Serializable]
    public class Kategori 
    {
        public string KategoriNamn { get; set; }

        public List<string> MakeLVItem()
        {
            return new List<string> { KategoriNamn };
        }

        public ListViewItem MakeListView()
        {
            return new ListViewItem(MakeLVItem().ToArray());
        }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("KategoriNamn", KategoriNamn);

        }
        public Kategori(SerializationInfo info, StreamingContext context)
        {
            KategoriNamn = (string)info.GetValue("KategoriNamn", typeof(string));
        }

        }

   
}
