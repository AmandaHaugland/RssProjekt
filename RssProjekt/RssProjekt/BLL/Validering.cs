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
          
            if (string.IsNullOrEmpty(url) ||
                string.IsNullOrEmpty(namn) ||
                kategori <= -1 ||
                uppdatering <= -1
               )
            {
                MessageBox.Show("Du måste fylla i fälten!");
                return false;
            }

            Uri uri = null;
            if (!Uri.TryCreate(url, UriKind.Absolute, out uri) || null == uri)
            {
                MessageBox.Show("fel url, försöka igen!");
                return false;
            }
            else
            {
            
                return true;
            }
           


        }
        public bool CheckIf(String namn)
        {
            if (string.IsNullOrEmpty(namn))
            {
                MessageBox.Show("Du måste fylla i fälten!");
                return false;
            }
            else
            {
                return true;
            }
        }

        
        public bool CheckIfKatExists(string katToCheck, List<string> listToCheck)
        {
            foreach(var thing in listToCheck)
            {
                if (thing.Equals(katToCheck))
                {
                    MessageBox.Show(katToCheck + " finns redan i listan!");
                    return true;
                }
            }
            return false;
        }
        
       public bool IfPodHasKat(string kat, List<Podcast> podcasts)
        {
            foreach(var pod in podcasts)
            {
                var podKat = pod.Kategori;
                if (podKat.Equals(kat))
                {
                    MessageBox.Show("Det finns minst en pod med kategorin " + kat + ". Ändra poddarnas kategorier och försök igen!");
                    return true;
                }
            }
            return false;
        }

        public bool SeeIfTextBoxIsEmpty(string tb)
        {
            if (string.IsNullOrEmpty(tb)){
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool IfCheckboxChanged(int cb)
        {
            if(cb <= -1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

    }
}
