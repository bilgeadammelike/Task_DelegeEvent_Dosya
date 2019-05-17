using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Threading.Tasks;
using Rss.MilliyetRss;
using Rss.MynetRss;
using Rss.PlugInDll;


namespace Rss.UI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }


        Thread thMilliyet;
        Thread thMynet;
        private object Haber;

        private void getirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            


            if (thMilliyet != null)
                thMilliyet.Start();

            if (thMynet != null)
                thMynet.Start();
        }

        public void Hede() {

            int deger = 0;

        }


        private void Form1_Load(object sender, EventArgs e)
        {
            //Hede();
            thMilliyet = new Thread(MilliyetDoldur);
            thMynet = new Thread(MynetDoldur);
        }

        private void MynetDoldur()
        {
            MynetRssReader mrr = new MynetRssReader();
            List<Haber> gelenHaberListem = mrr.HaberListesi();
            foreach (Haber item in gelenHaberListem)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.HaberKaynagi;
                li.SubItems.Add(item.HaberBasligi);
                System.Threading.Thread.Sleep(1000);
                tsProgress.Value = new Random().Next(0, 100);
                listView1.Items.Add(li);
            }
        }

        private void MilliyetDoldur()
        {
            MilliyetRssReader rdr = new MilliyetRssReader();
            List<Haber> haberlerim = rdr.HaberListesi();
            foreach (Haber item in haberlerim)
            {
                ListViewItem li = new ListViewItem();
                li.Text = item.HaberKaynagi;
                li.SubItems.Add(item.HaberBasligi);
                System.Threading.Thread.Sleep(1000);
                tsProgress.Value = new Random().Next(0, 100);
                listView1.Items.Add(li);
            }
        }

        private void durdurToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thMilliyet != null)
                thMilliyet.Suspend();

            if (thMynet != null)
                thMynet.Suspend();
        }

        private void devamEtToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (thMilliyet != null)
                thMilliyet.Resume();

            if (thMynet != null)
                thMynet.Resume();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
          

        }
    }
}
