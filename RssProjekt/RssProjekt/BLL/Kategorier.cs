﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssProjekt.BLL
{
    public class Kategorier
    {
        List<string> KategoriLista = new List<string>();

        public List<string> ReturnList()
        {
            return KategoriLista;
        }

        
    }
}
