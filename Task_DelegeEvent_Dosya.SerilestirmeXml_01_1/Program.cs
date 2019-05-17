using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_DelegeEvent_Dosya.SerilestirmeXml_01_1
{
    class Program
    {
        #region Default
        public static void Main(string[] args)
        {
            AddressDetails details = new AddressDetails();
            details.HouseNo = 4;
            details.StreetName = "HEde";
            details.City = "HedeninHedesi";
            Serialize(details);
        }
        static public void Serialize(AddressDetails details)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(AddressDetails));
            using (TextWriter writer = new StreamWriter(@"C:\Dosya\Xml.xml"))
            {
                serializer.Serialize(writer, details);
            }
        }
        #endregion

        #region ListSerialize
        //public static void Main(string[] args)
        //{
        //    List<AddressDetails> AddressList = new List<AddressDetails>();
        //    AddressDetails detail1 = new AddressDetails();
        //    detail1.HouseNo = 4;
        //    detail1.StreetName = "ABC";
        //    detail1.City = "Hede";

        //    AddressDetails detail2 = new AddressDetails();
        //    detail2.HouseNo = 3;
        //    detail2.StreetName = "ABCD";
        //    detail2.City = "Bidi";

        //    AddressList.Add(detail1);
        //    AddressList.Add(detail2);
        //    Serialize(AddressList);
        //}
        //public static void Serialize(List<AddressDetails> list)
        //{
        //    XmlSerializer serializer = new XmlSerializer(typeof(List<AddressDetails>));
        //    using (TextWriter writer = new StreamWriter(@"C:\Dosya\Xml.xml"))
        //    {
        //        serializer.Serialize(writer, list);
        //    }
        //        }
        #endregion

    }
}
