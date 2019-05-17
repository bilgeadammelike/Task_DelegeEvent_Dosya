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

namespace WindowsFormsApplication03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            CheckForIllegalCrossThreadCalls = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region 001
            //Task task1 = Task.Factory.StartNew(() =>
            //{
            //    for (int i = 0; i <= 30; i++)
            //    {
            //        Thread.Sleep(500);
            //        label1.Text = i + " ";
            //    }
            //});
            //Task task2 = Task.Factory.StartNew(() =>
            //{

            //    for (int j = 0; j <= 30; j++)
            //    {
            //        Thread.Sleep(500);
            //        label2.Text = j + " ";
            //    }
            //});
            #endregion
            #region 002
            //    Kullanım methodları
            //    Wait: TaskIsmi.Wait();
            //WaitAll: Task.WaitAll(TaskISmi1, TaskIsmi2….);
            //WaitAny: Task.WaitAny(TaskIsmi1, TaskIsmi2…);


            Task task1 = Task.Factory.StartNew(() =>
            {
                for (int i = 0; i <= 30; i++)
                {
                    Thread.Sleep(500);
                    label1.Text = i + " ";
                }

            })
            .ContinueWith((task2) =>
            {
                for (int j = 0; j <= 30; j++)
                {
                    Thread.Sleep(500);
                    label2.Text = j + " ";
                }
                if (task2.IsCompleted == true)
                {
                    MessageBox.Show("task görevi bitti");
                }

            });


            #endregion
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
