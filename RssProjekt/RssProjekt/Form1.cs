﻿using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RssProjekt
{
    public partial class Form1 : Form
    {
        private List<Podcast> Podcasts { get; set; }
        static Kategorier kategorier = new Kategorier();
        List<string> KategoriLista = kategorier.ReturnList();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            KategoriLista.Add("Hej");

            //Här kommer vi köra en metod som sätter Podcasts till det som finns i xml filen
            Podcasts = new List<Podcast>
            {
                new Podcast
                {
                    PodId = 0,
                    Namn = "Namnet",
                    Kategori ="Kat",
                    Avsnitt = 8,
                    RssUrl ="www.hmmm",
                    Uppdatering = "1 min"
                    

                }
            };
            UpdatePodList();
            UpdateKatLists();
        }

        public void UpdatePodList()
        {
            lvPodcast.Items.Clear();
            foreach(var pod in Podcasts)
            {
                lvPodcast.Items.Add(
                    pod.MakeListView());
            }
           }

        public void UpdateKatLists()
        {
            lvCategory.Items.Clear();
            
            
            foreach(var kat in KategoriLista)
            {
                lvCategory.Items.Add(kat); 
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {

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
            //Här ska vi köra en validering.....

            Validering valid = new Validering();
            valid.CheckIfPod(urlToAdd, nameToAdd, kategoriToAdd, uppdateringToAdd
                );  //Måste ändras då uppdatering och kategori ska tas in som int, här är de som text?
            //Desutom så kommer varningen två gånger?
            if (valid.CheckIfPod(urlToAdd, nameToAdd, kategoriToAdd, uppdateringToAdd))
            {
                Podcast podToAdd = new Podcast
                {
                    Namn = nameToAdd,
                    RssUrl = urlToAdd,
                    Kategori = kategoriToAdd,
                    Uppdatering = uppdateringToAdd
                };





                tbName.Clear();
                tbUrl.Clear();
                cbCategory.SelectedIndex = -1;
                cbUpdate.SelectedIndex = -1;
                Podcasts.Add(podToAdd);
                UpdatePodList();
            }
        }
    }
}
