using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
   public class Validering
    {
        public bool CheckIfPod(String url, String namn, int kategori, int uppdatering)
        {

            if (string.IsNullOrEmpty(url) ||
                string.IsNullOrEmpty(namn) ||
                kategori <= -1 ||
                uppdatering <= -1
                )
            {
                MessageBox.Show("fel");
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
