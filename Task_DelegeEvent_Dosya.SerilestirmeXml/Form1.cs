using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Serialization;

namespace Task_DelegeEvent_Dosya.SerilestirmeXml
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Stream stream = null;
            try
            {
                Order order = new Order();
                order.Add(new Item("Kivi", 10));
                order.Add(new Item("Portakal", 20));
                order.Add(new Item("Çilek", 30));


                XmlSerializer serializer = new XmlSerializer(typeof(Order));
                stream = new FileStream("ComplexSerialization.xml", FileMode.Create);
                serializer.Serialize(stream, order);
                stream.Close();
            }
            catch (Exception ex)
            {
                stream.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

       }


        private void button2_Click(object sender, EventArgs e)
        {
            Book book1 = new Book();
            Price price1 = new Price();
            price1.currency = "TL";
            price1.price = 49.99M;
            book1.Title = "Wep Api 2.0";
            book1.price = price1;
            Book book2 = new Book();
            Price price2 = new Price();
            price2.currency = "USD";
            price2.price = 39.99M;
            book2.Title = "Divergent";
            book2.price = price2;


            Books books = new Books();
            books.alBooks.Add(book1);
            books.alBooks.Add(book2);

            XmlSerializerNamespaces namespaces = new XmlSerializerNamespaces();
            namespaces.Add("Hede", "hedebidimidisidi");

            Stream stream = new FileStream("Namespaces.xml", FileMode.Create, FileAccess.Write, FileShare.Write);
            XmlSerializer serializer = new XmlSerializer(typeof(Books));
            serializer.Serialize(stream, books, namespaces);
            stream.Close();
        }
    }
    [Serializable]
    public class Price
    {
        [XmlAttribute(Namespace = "Currency-hedebidimidisidi")]
        public string currency;
        [XmlAttribute(Namespace = "Price-hedebidimidisidi")]
        public decimal price;
    }
    [Serializable]
    public class Book
    {
        [XmlElement(Namespace = "Title-hedebidimidisidi")]
        public string Title;
        [XmlElement(Namespace = "Price-hedebidimidisidi")]
        public Price price;
    }
    [Serializable]
    public class Books
    {
        [XmlElement(typeof(Book), Namespace = "Books___hedebidimidisidi",ElementName ="elementAdi")]
        public List<Book> alBooks = new List<Book>();
    }
}
