using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_DelegeEvent_Dosya.SerilestirmeXml
{
    [Serializable]
    public class Item
    {
        public string strProductName;
        [XmlElement(ElementName = "Hede Name")]
        public int nProductID;
        public Item()
        {
            strProductName = "";
            nProductID = 0;
        }
        public Item(string s, int n)
        {
            strProductName = s;
            nProductID = n;
        }
    }
}
