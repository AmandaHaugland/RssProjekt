using RssProjekt.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssProjekt.BLL
{
    public class Kategorier
    {
        List<string> KategoriLista = new List<string>();
        static XmlKategori xmlKategori = new XmlKategori();

        public List<string> ReturnList()
        {
            return KategoriLista;
        }

    //    public void AddKatToList(string katToAdd)
    //    {
    //        xmlKategori.AddKategoriToXml(katToAdd);
    //        KategoriLista.Add(katToAdd);
    //    }
    }
}
