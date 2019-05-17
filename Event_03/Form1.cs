using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //button1.Click += Button1_Click;
            //button1.Click += new EventHandler(Tiklandi);



            #region Başka bir sınıftakieventitetiklet
            //SayiKontrol nesne = new SayiKontrol();
            //nesne.SayiDurumu += new SayiKontrol.SayiKontrolEtHandler(kontrol);
            //nesne.Sayi = 7; 
            #endregion
        }
        void kontrol()
        {
            MessageBox.Show("Sayi özelliği 10 dan küçük olamaz");
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        void Tiklandi(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
