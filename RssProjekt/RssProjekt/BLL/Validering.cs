using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt.BLL
{
   public class Validering
    {
        public bool CheckIf(String url, String namn, int kategori, int uppdatering)
        {
            Regex rx = new Regex(@"/^(https?:\/\/)[a-zA-Z0-9]+\.[a-zA-Z0-9]+\.[a-zA-Z0-9]+\/[a-zA-Z0-9]+/");

            if (string.IsNullOrEmpty(url) ||
                string.IsNullOrEmpty(namn) ||
                kategori<= -1 ||
                uppdatering <= -1
               )
           {
                MessageBox.Show("Du måste fylla i fälten!");
                return false;
                //Lägg till felmeddelande??
                
            }

             else if (!url.Equals(rx))
            {
                MessageBox.Show("Url är fel, försöka igen");
                return false;
            }
            else
            {
            
                return true;
            }
           


        }
        public bool CheckIf(String kategoriNamn)
        {
            if (string.IsNullOrEmpty(kategoriNamn))
            {
                MessageBox.Show("Du måste fylla i fälten!");
                return false;
            }
            else
            {
                return true;
            }
        }
       
        

    }
}
