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
        ListViewItem MakeListView();
        List<string> MakeLVItem();

        //int MakeId();
    }
}
