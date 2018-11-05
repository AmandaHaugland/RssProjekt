using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
    interface ILists
    {
        ListViewItem MakeListView(string title);
        List<string> MakeLVItem(string title);

        //int MakeId();
    }
}
