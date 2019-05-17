using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        Thread th;
        private void button1_Click(object sender, EventArgs e)
        {
            th.Start();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            th = new Thread(Cagir);
        }

        private void Cagir()
        {

            for (int i = 0; i < 1000000; i++)
            {
                listBox1.Items.Add(i.ToString());
                System.Threading.Thread.Sleep(1000);

            }

        }
    }
}
