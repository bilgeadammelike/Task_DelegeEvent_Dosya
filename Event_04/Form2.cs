using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Event_04
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        public delegate void delegemBenim(TextBox txtBox);

        public event delegemBenim olayimBenim;

        private void btnIsimEkle_Click(object sender, EventArgs e)
        {
            this.olayimBenim(txtIsim);
        }

    }
}
