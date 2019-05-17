using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Task_DelegeEvent_Dosya.SerilestirmeXml
{
    [Serializable]
    public class Order
    {
        // Serileştirilecek nesne karmaşık bir nesneye referans için referans edilen 
        // nesne serileştirilirken element olarak kullanılacağı belirtilmelidir.
        // Bu konu ile ilgili daha detaylı olarak aşağıdaki konu başlığında bulabilirsiniz;
        // XML Serileştirmeyi Etiket Kullanarak Kontrol Etmek
        [XmlElement(typeof(Item))]
        public List<Item> alOrders;
        public Order()
        {
            alOrders = new List<Item>();
        }
        [XmlInclude(typeof(Item))]
        public void Add(Item i)
        {
            alOrders.Add(i);
        }
    }
 
}
