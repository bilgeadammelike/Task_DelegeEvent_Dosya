using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rss.PlugInDll;
using System.Net;
using System.Xml;

namespace Rss.MynetRss
{
    public class MynetRssReader : IHaberOkuyabilme
    {

        public string DefaultURL
        {
            get
            {

                return "http://sinema.mynet.com/rss/RSS-enyeniler/rss.xml";
            }
        }

        private string _sourceURL;
        public string SourceURL
        {
            get
            {
                return _sourceURL;
            }
            set
            {
                _sourceURL = value;
            }
        }

        public List<Haber> HaberListesi(string URL = "http://www.milliyet.com.tr/rss/rssNew/SonDakikaRss.xml")
        {
            List<Haber> haberListem = new List<Haber>();
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string xmlData = wc.DownloadString(URL);
            XmlDocument Xdoc = new XmlDocument();
            Xdoc.LoadXml(xmlData);

            string sourceName = Xdoc.SelectSingleNode("rss/channel/title").InnerText;
           
            foreach (XmlNode item in Xdoc.SelectNodes("rss/channel/item"))
            {
                Haber h = new Haber();
                h.HaberBasligi = item.SelectSingleNode("title").InnerText;
                //h.HaberKaynagi = sourceName;
                h.HaberKaynagi = "Diğer Kaynak";
                h.HaberLinki = item.SelectSingleNode("link").InnerText;
                haberListem.Add(h);
            }
            return haberListem;
        }
    }
}
