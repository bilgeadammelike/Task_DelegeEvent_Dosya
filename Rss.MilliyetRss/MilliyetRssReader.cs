using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Rss.PlugInDll;
using System.Net;
using System.Xml;

namespace Rss.MilliyetRss
{
  public  class MilliyetRssReader:IHaberOkuyabilme
    {
        private string _SourceURL;
        public string SourceURL
        {
            get
            {
                return _SourceURL;
            }
            set
            {
                _SourceURL = value;
            }
        }

        public List<Haber> HaberListesi(string URL = " http://www.milliyet.com.tr/rss/rssNew/otomobilRss.xml")
        {

            List<Haber> haberlistesi = new List<Haber>();
            try
            {
                WebClient wc = new WebClient();
                wc.Encoding = Encoding.UTF8;
                string gelenXmlData = wc.DownloadString(URL);

                XmlDocument xdocument = new XmlDocument();
                xdocument.LoadXml(gelenXmlData);
                string source = xdocument.SelectSingleNode("rss/channel/title").InnerText;
                foreach (XmlNode item in xdocument.SelectNodes("rss/channel/item"))
                {
                    Haber h = new Haber();
                    h.HaberLinki = item.SelectSingleNode("link").InnerText;
                    h.HaberBasligi = item.SelectSingleNode("title").InnerText;
                    h.HaberKaynagi = source;
                    haberlistesi.Add(h);
                }
            }
            catch (Exception)
            {

            }
            return haberlistesi;
        }

        public string DefaultURL
        {
            get
            {
                return "http://www.milliyet.com.tr/rss/rssNew/otomobilRss.xml";
            }
        }
    }
}
