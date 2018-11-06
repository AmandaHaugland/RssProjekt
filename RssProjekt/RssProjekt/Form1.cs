using RssProjekt.BLL;
using RssProjekt.DL;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace RssProjekt
{
    public partial class Form1 : Form
    {
       static private List<Podcast> Podcasts { get; set; }
       static Dictionary<string, List<Feed>> FeedDictionary = new Dictionary<string, List<Feed>>();
        static Podcast podcastIn = new Podcast();

        static Kategorier kategorier = new Kategorier();
        List<string> KategoriLista = kategorier.ReturnList();
        static XmlKategori xmlKategori = new XmlKategori();

        static Feed feed = new Feed();
        static XmlPod xmlPodcast = new XmlPod();
        static XmlFeed xmlFeed = new XmlFeed();

        static UppdateraFeed uppdateraFeed = new UppdateraFeed();
        static Metoder metoder = new Metoder();
        
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Kolla om xml filer finns
            xmlPodcast.ifItExists(Podcasts);
            xmlKategori.ifItExists(KategoriLista);

            //Ladda in xmlfiler till listor
            Podcasts = xmlPodcast.loadSavedPods(Podcasts);
            KategoriLista = xmlKategori.LoadSavedKats(KategoriLista);
            UppdateDictionary();

            StartLookingForUppdates();
            UpdatePodList();
            UpdateKatLists();

        }

        public void UpdatePodList()
        {
            lvPodcast.Items.Clear();
           // Podcasts = new List<Podcast>();
            Podcasts = xmlPodcast.loadSavedPods(Podcasts);
            Metoder metod = new Metoder();

            foreach (var pod in Podcasts)
            {
                var feed = FeedDictionary[pod.PodId.ToString()];
                int antalAvsnitt = metod.AntalAvsnitt(feed);
                lvPodcast.Items.Add(pod.MakeListView(pod.PodId.ToString(), pod.RssUrl, pod.Namn, antalAvsnitt.ToString(), pod.Kategori, pod.Uppdatering));
            }
            


           }

        public void UpdateKatLists()
        {
            lvCategory.Items.Clear();
            cbCategory.Items.Clear();
            
            foreach (var kat in KategoriLista)
            {
               
                lvCategory.Items.Add(kat);
                cbCategory.Items.Add(kat);
            }
        }

        

        private void button2_Click(object sender, EventArgs e)
        {
            var addKategori = tbKategori.Text.Trim();
            Validering validering = new Validering();
            
            if (validering.CheckIf(addKategori))
            {
                if (!validering.CheckIfKatExists(addKategori, KategoriLista))
                {

                    KategoriLista.Add(tbKategori.Text.Trim());
                    xmlKategori.AddKategoriToXml(KategoriLista);
                    UpdateKatLists();
                    tbKategori.Clear();
                }
                    

                    
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
                AsyncMethod();
                label6.Text = "Wating...";
                var idToAdd = podcastIn.MakeId(Podcasts);


                Metoder metoder = new Metoder();
                var podToAdd = metoder.NewPodcast(nameToAdd, urlToAdd, kategoriToAdd, uppdateringToAdd, idToAdd);

                tbName.Clear();
                tbUrl.Clear();
                cbCategory.SelectedIndex = -1;
                cbUpdate.SelectedIndex = -1;
                Podcasts.Add(podToAdd);
                xmlPodcast.addPodToXml(Podcasts);
                UpdateTimer(uppdateringToAdd, urlToAdd, idToAdd.ToString());

                List<Feed> feedToAdd = xmlFeed.makeFeed(urlToAdd);
                xmlFeed.addMappForFeed(idToAdd.ToString());
                xmlFeed.AddFeedToXml(feedToAdd, idToAdd.ToString());
                FeedDictionary[idToAdd.ToString()] = feedToAdd;
               
                UpdatePodList();
            }
        }

        

        public async void AsyncMethod()
        {
            var result = await TaskMethod("Podcast lagt till!");
            label6.Text = result;
         var result2 = await Task.Factory.StartNew(() => ThreadMetod());
            label6.Text = result2;

        }
        public Task<string> TaskMethod(string meddelande)
        {
            return Task.Factory.StartNew(() => AMethod(meddelande));
        }
        public string AMethod(string meddelande)
        {
            Thread.Sleep(1000);
            return "Klart! " + meddelande;
        }
        public string ThreadMetod()
        {
            Thread.Sleep(2000);
            return "";
            
        }


        private void btnTaBortPod_Click(object sender, EventArgs e)
        {
           // var nameToRemove = tbName.Text.Trim();
           // Validering valid = new Validering();
           // if (valid.CheckIf(nameToRemove)) {
           //     TaBortPod();
           //
           // 
           //         MessageBox.Show("Podcast tog bort");
           //     }
           //     tbName.Clear();

            if(lvPodcast.SelectedItems.Count > 0)
            
            {
                TaBortPod();
                string selectedPod = lvPodcast.SelectedItems[0].Text;
                Podcasts.Remove(Podcasts.Find(p => p.PodId.Equals(selectedPod)));
                //  FeedDictionary[selectedPod].Remove(FeedDictionary[selectedPod]);
                var dir = new DirectoryInfo(@"Feed/" + selectedPod);
                dir.Delete(true);
                xmlPodcast.addPodToXml(Podcasts);
              // FeedDictionary = xmlFeed.LoadDictionary( Podcasts);
                UpdatePodList();


            }
            }
            

        
        public bool TaBortPod()
        {
           
            Podcast podToDelete = new Podcast();
            XmlDocument doc = new XmlDocument();
            doc.Load("xmlpodcasts.xml");
            foreach (XmlNode xNode in doc.SelectNodes("ArrayOfPodcast/Podcast"))
            {
                if (xNode.SelectSingleNode("PodId").InnerText == lvPodcast.SelectedItems[0].Text) xNode.ParentNode.RemoveChild(xNode);
                doc.Save("xmlpodcasts.xml");

                UpdatePodList();

            }
            return true;

        }

        public void UpdateTimer(string uppd, string url, string id)
        {
            int timerTime = 15000;
            if(uppd.Equals("30 minuter"))
            {
                timerTime = 1800000;
            } else if(uppd.Equals("1 timme"))
            {
                timerTime = 3600000;
            }
           
            else
            {
                timerTime = 10800000;
            }
            System.Timers.Timer timer = new System.Timers.Timer(timerTime);
            timer.Elapsed += (sender, e) => { OnTimedEvent(url, id); };
            timer.Enabled = true;
        }


        private static void OnTimedEvent(string url, string id)
        {
            
            if (uppdateraFeed.CheckIfUpdated(id, url))
            {
               
                var feedToAdd = xmlFeed.makeFeed(url);
                xmlFeed.AddFeedToXml(feedToAdd, id);
                UppdateDictionary();
            }

        }

        static public void UppdateDictionary ()
        {
            FeedDictionary = xmlFeed.LoadDictionary(Podcasts);
        }


       
        public void StartLookingForUppdates()
        {
            foreach(Podcast pod in Podcasts)
            {
                string uppdatering = pod.Uppdatering;
                string id = pod.PodId.ToString();
                string url = pod.RssUrl;
                UpdateTimer(uppdatering, url, id);
            }
        }

        private void lvCategory_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                string selectedKat = lvCategory.SelectedItems[0].Text;
              
                lvPodcast.Items.Clear();
                var listToUse = metoder.ListWhereKat(selectedKat, Podcasts);
                foreach (var pod in listToUse)
                {
                    lvPodcast.Items.Add(pod.MakeListView(pod.PodId.ToString(), pod.RssUrl, pod.Namn, pod.Avsnitt.ToString(), pod.Kategori, pod.Uppdatering));
                }
            }
            else
            {
                UpdatePodList();
            }
                
        }

       

        private void lvPodcast_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lvPodcast.SelectedItems.Count > 0)
            {
                string selected = lvPodcast.SelectedItems[0].Text;
                List<Feed> listToUse = FeedDictionary[selected];
                lVFeed.Items.Clear();
                foreach(var feed in listToUse)
                {
                    lVFeed.Items.Add(feed.MakeListView(feed.Title));
                }
               
                 }
            else
            {
                lVFeed.Items.Clear();
            }
        }

        private void ändraKtegori_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                Validering validering = new Validering();
                
                if (validering.CheckIf(tbKategori.Text.Trim()))
                {
                    string selectedKat = lvCategory.SelectedItems[0].Text;
                    string nyKategori = tbKategori.Text.Trim();

                    if(!validering.CheckIfKatExists(nyKategori, KategoriLista))
                    {

                    
                    KategoriLista.Remove(selectedKat);
                    KategoriLista.Add(nyKategori);
                    foreach(var pod in Podcasts)
                    {
                        var podsKat = pod.Kategori;
                        if (podsKat.Equals(selectedKat))
                        {
                            pod.Kategori = nyKategori;
                        }
                    }
                    xmlPodcast.addPodToXml(Podcasts);
                    xmlKategori.AddKategoriToXml(KategoriLista);
                    UpdatePodList();
                    UpdateKatLists();
                    }
                }
                
            }
        }

        private void taBortKategorie_Click(object sender, EventArgs e)
        {
            if (lvCategory.SelectedItems.Count > 0)
            {
                Validering validering = new Validering();
               // if (validering.CheckIf(tbKategori.Text.Trim()))
                
                    string selectedKat = lvCategory.SelectedItems[0].Text;
                    //string taBortKat = tbKategori.Text.Trim();

                    if (!validering.IfPodHasKat(selectedKat, Podcasts))
                    {
                        KategoriLista.Remove(selectedKat);
                        xmlKategori.AddKategoriToXml(KategoriLista);
                        UpdateKatLists();
                    }
                
            }
        }


        private void btnAndraPod_Click(object sender, EventArgs e)
        {
            Podcast podToChange = new Podcast();
          // List<string> podLista = podToChange.MakeLVItem(tbUrl.Text);


                 if (lvPodcast.SelectedItems.Count > 0)
            {
                Validering validering = new Validering();

                if (!validering.SeeIfTextBoxIsEmpty(tbUrl.Text) || validering.IfCheckboxChanged(cbCategory.SelectedIndex) || validering.IfCheckboxChanged(cbUpdate.SelectedIndex))
                {
                    string selectedPod = lvPodcast.SelectedItems[0].Text;
                    

                    string nyUrl = tbUrl.Text.Trim();
                    string nyKat = cbCategory.Text;
                    string nyUppdatering = cbUpdate.Text;
                    Podcast podToRemove = new Podcast();

                    var podIdToRemove = 0; 


               foreach(var pod in Podcasts)
                    {
                        string podIdToCheck = pod.PodId.ToString();
                        if (podIdToCheck.Equals(selectedPod))
                        {
                            podIdToRemove = pod.PodId;
                            podToRemove = pod;
                            var oldUrl = pod.RssUrl;
                            //var oldName = pod.Namn;
                            var oldKat = pod.Kategori;
                            var oldUppdatering = pod.Uppdatering;
                            
                            if (!validering.SeeIfTextBoxIsEmpty(tbUrl.Text))
                            {
                                podToChange.RssUrl = nyUrl;

                                List<Feed> feedToAdd = xmlFeed.makeFeed(nyUrl);
                                //xmlFeed.addMappForFeed(idToAdd.ToString());
                                xmlFeed.AddFeedToXml(feedToAdd, pod.PodId.ToString());
                                FeedDictionary[pod.PodId.ToString()] = feedToAdd;
                            } else
                            {
                                podToChange.RssUrl = oldUrl;
                            }

                            if (validering.IfCheckboxChanged(cbCategory.SelectedIndex))
                            {
                                podToChange.Kategori = nyKat;
                            }
                            else
                            {
                                podToChange.Kategori = oldKat;
                            }

                            if (validering.IfCheckboxChanged(cbUpdate.SelectedIndex))
                            {
                                podToChange.Uppdatering = nyUppdatering;
                            }
                            else
                            {
                                podToChange.Uppdatering = oldUppdatering;
                            }
                            podToChange.PodId = pod.PodId;
                            podToChange.Namn = pod.Namn;

                            Podcasts = metoder.SortPodList(Podcasts);
                            xmlPodcast.addPodToXml(Podcasts);
                            UpdatePodList();
                        }
                        
                    }


                    Podcasts.Remove(Podcasts.Find(x => x.PodId.Equals(podIdToRemove)));
                    //Podcasts.Remove(podToRemove);
                    Podcasts.Add(podToChange);

                }

            }
        }

       

        private void lVFeed_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            lblBeskrivning.Text = "";
            if(lVFeed.SelectedItems.Count > 0)
            {
                string selected = lvPodcast.SelectedItems[0].Text;
                List<Feed> listToUse = FeedDictionary[selected];

                string selectedAvsnitt = lVFeed.SelectedItems[0].Text;

                var description = (listToUse.Find(a => a.Title.Equals(selectedAvsnitt))).Description; 
                lblBeskrivning.Text =  description.ToString();


                
            }
        }

       
    }
}
