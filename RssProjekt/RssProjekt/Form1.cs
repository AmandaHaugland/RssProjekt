using RssProjekt.BLL;
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
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Här kommer vi köra en metod som sätter Podcasts till det som finns i xml filen
            Podcasts = new List<Podcast>
            {
                new Podcast
                {
                    Namn = "Namnet",
                    Kategori ="Kat",
                    RssUrl ="www.hmmm",
                    Uppdatering = "1 min"

                }
            };
            UpdatePodList();
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

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void tbUrl_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
