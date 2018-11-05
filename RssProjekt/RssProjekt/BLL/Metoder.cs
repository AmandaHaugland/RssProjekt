using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssProjekt.BLL
{
    class Metoder
    {
        public int AntalAvsnitt(List<Feed> feed)
        {
            return feed.Count();
        }
    }
}
