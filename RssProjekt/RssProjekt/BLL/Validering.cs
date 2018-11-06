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
            try
            {
                if (string.IsNullOrEmpty(namn))
                {
                    MessageBox.Show("Du måste fylla i fälten!");
                    return false;
                }
                return true;
            }
           
           catch(Exception e)
            {
                MessageBox.Show("" + e.Message);
                return true;
            }
        }

        
        public bool CheckIfKatExists(string katToCheck, List<string> listToCheck)
        {
            try
            {
                foreach (var thing in listToCheck)
                {
                    if (thing.Equals(katToCheck))
                    {
                        MessageBox.Show(katToCheck + " finns redan i listan!");
                        return true;
                    }
                }
                return false;
            } catch (Exception e)
            {
                MessageBox.Show("Försökte kolla om kategori finns. Felmeddelande: " + e.Message);
                return true;
            }
        }
        
       public bool IfPodHasKat(string kat, List<Podcast> podcasts)
        {
            try
            {
                foreach (var pod in podcasts)
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
            catch(Exception e)
            {
                MessageBox.Show("Försökte kolla om det finns kategori med namnet "  + kat + e.Message);
                return true;
            }
        }

        public bool SeeIfTextBoxIsEmpty(string tb)
        {
            try
            {

                if (string.IsNullOrEmpty(tb))
                {
                    return true;
                }
                return false;
            }catch (Exception e)
            
            {
                MessageBox.Show("" + e.Message);
               

                return false;
            }
        }

        public bool IfCheckboxChanged(int cb)
        {
            try
            {
                if (cb <= -1)
                {
                    return false;
                }
                return true;
            }
            catch(Exception e)
            {
                MessageBox.Show("lag" + e.Message);
                return true;
            }
        }

    }
}
