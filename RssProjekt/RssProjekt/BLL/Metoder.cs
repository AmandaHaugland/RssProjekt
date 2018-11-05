using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RssProjekt.BLL
{
    class Metoder
    {
        public int AntalAvsnitt(List<Feed> feed)
        {
            return feed.Count();
        }

        public Podcast NewPodcast(string namn, string url, string kategori, string uppdatering, int id)
        {
            

            Podcast podToAdd = new Podcast
            {
                Namn = namn,
                RssUrl = url,
                Kategori = kategori,
                Uppdatering = uppdatering,
                PodId = id
            };

            return podToAdd;
        }

        public List<Podcast> ListWhereKat(string kat, List<Podcast> podcasts)
        {
            List<Podcast> newList = podcasts.Where(pod => pod.Kategori.Equals(kat)).ToList();
            return newList;
        }

        public List<Podcast> SortPodList(List<Podcast> podcasts)
        {
           return podcasts = podcasts.OrderBy(p => p.PodId).ToList();
        }
    }
}
