using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

 
namespace RssProjekt.BLL
{
    [Serializable()]
    public class Feed : ISerializable
    {
        public string Title { get; set; }
        public string Description { get; set; }
        //public string PubDate { get; set; }
       // public int PodId { get; set; }

        public Feed() { }

        public void GetObjectData(SerializationInfo info, StreamingContext context)
        {
            info.AddValue("Title", Title);
            info.AddValue("Description", Description);
            //info.AddValue("PodId", PodId);
            // info.AddValue("PubDate", PubDate);
            //  throw new NotImplementedException();
        }

        public Feed(SerializationInfo info, StreamingContext context)
        {
            Title = (string)info.GetValue("Title", typeof(string));
            Description = (string)info.GetValue("Description", typeof(string));
            //PodId = (int)info.GetValue("PodId", typeof(string));
            //PubDate = (string)info.GetValue("PubDate", typeof(string));
        }


    }
}
