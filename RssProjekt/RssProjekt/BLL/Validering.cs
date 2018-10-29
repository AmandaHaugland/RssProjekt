using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssProjekt.BLL
{
    class Validering
    {
        public bool CheckIfPod(String url, String namn, int kategori, int uppdatering)
        {

            if (string.IsNullOrEmpty(url) ||
                string.IsNullOrEmpty(namn) ||
                kategori <= -1 ||
                uppdatering <= -1
                )
            {
                return false;
                //Lägg till felmeddelande??
            }
            else
            {
                return true;
            }


        }
    }
}
