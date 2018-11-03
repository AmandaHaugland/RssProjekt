using RssProjekt.BLL;
using RssProjekt.DL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt
{
    public partial class Form1 : Form
    {
        private List<Podcast> Podcasts { get; set; }
        Dictionary<string, List<Feed>> FeedDictionary = new Dictionary<string, List<Feed>>();
        static Podcast podcastIn = new Podcast();

        static Kategorier kategorier = new Kategorier();
        List<string> KategoriLista = kategorier.ReturnList();
        static XmlKategori xmlKategori = new XmlKategori();

        static Feed feed = new Feed();
        static XmlPod xmlPodcast = new XmlPod();
        static XmlFeed xmlFeed = new XmlFeed();


        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

            xmlPodcast.ifItExists(Podcasts);
            Podcasts = xmlPodcast.loadSavedPods(Podcasts);
            UpdatePodList();
            UpdateKatLists();
        }

        public void UpdatePodList()
        {
            lvPodcast.Items.Clear();
           // Podcasts = new List<Podcast>();
            Podcasts = xmlPodcast.loadSavedPods(Podcasts);
            xmlFeed.addMappForFeed("TestMapp");


            foreach (var pod in Podcasts)
            {
                lvPodcast.Items.Add(
                    pod.MakeListView());
            }


           }

        public void UpdateKatLists()
        {
            lvCategory.Items.Clear();
            cbCategory.Items.Clear();

            string[] kategoriListan = Directory.GetDirectories(Directory.GetCurrentDirectory());
            
            foreach (var kat in kategoriListan)
            {
                string[] trimKat = kat.Split('\\');
                int langd = trimKat.Length - 1;
                
                lvCategory.Items.Add(trimKat[langd]);
                cbCategory.Items.Add(trimKat[langd]);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var addKategori = tbKategori.Text.Trim();
            Validering katNamn = new Validering();
            //Lägg till validering
            if (katNamn.CheckIf(addKategori))
            {
                kategorier.AddKatToList(tbKategori.Text.Trim());

                //KategoriLista.Add(tbKategori.Text.Trim());
                UpdateKatLists();
                tbKategori.Clear();
            }
          
        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnLaggTillPod_Click(object sender, EventArgs e)
        {
            var urlToAdd = tbUrl.Text.Trim();
            var nameToAdd = tbName.Text.Trim();
            var kategoriToAdd = cbCategory.Text;
            var uppdateringToAdd = cbUpdate.Text;

            
            int indexUppdatering = cbUpdate.SelectedIndex;
            int indexKategori = cbCategory.SelectedIndex;
            //Här ska vi köra en validering.....

            Validering valid = new Validering();
           
                
             
            if (valid.CheckIf(urlToAdd, nameToAdd, indexKategori, indexUppdatering))
            {
                var idToAdd = podcastIn.MakeId(Podcasts);
                Podcast podToAdd = new Podcast
                {
                    Namn = nameToAdd,
                    RssUrl = urlToAdd,
                    Kategori = kategoriToAdd,
                    Uppdatering = uppdateringToAdd,
                    PodId = idToAdd
                };





                tbName.Clear();
                tbUrl.Clear();
                cbCategory.SelectedIndex = -1;
                cbUpdate.SelectedIndex = -1;
                Podcasts.Add(podToAdd);
                xmlPodcast.addPodToXml(Podcasts);

                List<Feed> feedToAdd = xmlFeed.makeFeed(urlToAdd);
                xmlFeed.addMappForFeed(idToAdd.ToString());
                xmlFeed.AddFeedToXml(feedToAdd, idToAdd.ToString());

                //Lägger till Feeden i dictionary med podid som nyckel
                // List<Feed> feedListToAdd = new List<Feed>();
                // feedListToAdd = xmlFeed.makeFeed(urlToAdd);
                // FeedDictionary[idToAdd.ToString()] = feedListToAdd;

                FeedDictionary[idToAdd.ToString()] = feedToAdd;
               
                UpdatePodList();
            }
        }

        private void btnTestFeed_Click(object sender, EventArgs e)
        {
            List<Feed> testFeedList = new List<Feed>();
            testFeedList = xmlFeed.makeFeed(@"http://lorepodcast.libsyn.com/rss");
            MessageBox.Show(testFeedList.Count + testFeedList[1].Title + " Beskrivning " + testFeedList[1].Description);
        }
    }
}
