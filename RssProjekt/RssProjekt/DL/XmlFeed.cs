﻿using RssProjekt.BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.ServiceModel.Syndication;
using System.IO;
using System.Xml.Serialization;
using System.Windows.Forms;

namespace RssProjekt.DL
{
    class XmlFeed
    {
        //använd denna genom att sätta lista = metoden. Namnsätt lista efter podID, så blir pod kopplat till feed
        //Måste köra en metod som ser till att det är en url som skickas in

            //Vi måste jobba med undantag och felhantering.......
        public List<Feed> makeFeed(string rssUrl)
        {
            List<Feed> listOfFeed = new List<Feed>();
            try
            {
               
                XmlReader reader = XmlReader.Create(rssUrl);
                var syndicationFeed = SyndicationFeed.Load(reader);
                foreach (var item in syndicationFeed.Items)
                {
                    Feed feed = new Feed();
                    feed.Title = item.Title.Text;
                    feed.Description = item.Summary.Text;
                    //feed.PodId = podId;
                    listOfFeed.Add(feed);
                }
                
            } catch(Exception ex)
            {
                MessageBox.Show("Det gick inte att göra feed, kolla Url. Felmeddelande: " + ex.Message);
            }
            return listOfFeed;
        }

        
        //Gör en mapp för varje feed. Mappnamn ska vara podId
        public void addMappForFeed (string mappNamn)
        {
            Directory.CreateDirectory("Feed//" + mappNamn);
        }

        public void AddFeedToXml(List<Feed> listOfFeed, string mapp)
        {
            try
            {
                string path = "Feed//" + mapp + "/feed.xml";

                using (Stream fs = new FileStream(path,
                    FileMode.Create, FileAccess.Write, FileShare.None))
                {
                    XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>));
                    serializer.Serialize(fs, listOfFeed);

                }
            } catch (Exception ex)
            {
                MessageBox.Show("Det gick inte att spara feeden i xml. /n Felmeddelande: " + ex.Message);
            }
        }

        //Tar in ett id och hämtar och deserialize feeden som är sparad under den id
        public List<Feed> LoadSavedFeeds(string podId)
        {
            var path = "Feed//" + podId + "/feed.xml";
            List<Feed> feedToReturn = new List<Feed>();
            try
            {
                XmlSerializer serializer = new XmlSerializer(typeof(List<Feed>));
                using (FileStream fs = File.OpenRead(path))
                {
                    feedToReturn = (List<Feed>)serializer.Deserialize(fs);
                }
            } catch(Exception ex)
            {
                MessageBox.Show("Det gick inte att ladda sparade Feed. Felmeddelande : " + ex.Message);
            }
            return feedToReturn;
        }


        //Denna metod ska köras när programmet startar, läser in de sparade poddarna
        public Dictionary<string, List<Feed>> LoadDirectory(List<Podcast> podcasts)
        {
            
            Dictionary<string, List<Feed>> dictionaryToReturn = new Dictionary<string, List<Feed>>();
            try
            {
                foreach (Podcast pod in podcasts)
                {
                    var id = pod.PodId;
                    dictionaryToReturn[id.ToString()] = LoadSavedFeeds(id.ToString());

                }
            } catch(Exception ex)
            {
                MessageBox.Show("Det gick inte att läsa in alla sparade feeds. Felmeddelande : " + ex.Message);
            }
            return dictionaryToReturn;
            
        }
        

        }
    }

