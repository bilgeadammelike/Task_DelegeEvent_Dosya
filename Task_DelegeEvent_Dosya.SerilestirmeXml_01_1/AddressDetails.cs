using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_DelegeEvent_Dosya.SerilestirmeXml_01_1
{
    #region IlkOrnek
    public class AddressDetails
    {
        #region DEfault
        public int HouseNo { get; set; }
        public string StreetName { get; set; }
        public string City { get; set; }
        private string PoAddress { get; set; }
        #endregion

        #region XmlElement

        //[XmlElement("Number")]
        //public int HouseNo { get; set; }
        //[XmlElement("Street")]
        //public string StreetName { get; set; }
        //[XmlElement("CityName")]
        //public string City { get; set; }
        #endregion

        #region XmlAttr
        //    [XmlAttribute("Number")]
        //public int HouseNo { get; set; }
        //    [XmlElement("Street")]
        //    public string StreetName { get; set; }
        //    [XmlElement("CityName")]
        //    public string City { get; set; }
        #endregion

        #region IgnoreXml
        //[XmlElement("Number")]
        //public int HouseNo;
        //[XmlElement("Street")]
        //public string StreetName;
        //[XmlIgnore]
        //public string City;
        #endregion


    }
    #endregion


    //[XmlRoot("Root")]
    //public class AddressDetails
    //{
    //    [XmlElement("Number")]
    //    public int HouseNo;
    //    [XmlElement("Street")]
    //    public string StreetName;
    //    [XmlElement("CityName")]
    //    public string City;
    //}
}
