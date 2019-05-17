using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DelegateOrnek
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        public delegate void MyDelegeHandler();
        //public delegate void MyDelegeHandler2(int a, int b);
        //public delegate int MyDelegeHandler3(int a, int b);
        //public delegate string MyDelegeHandler4();

    
        public void x()
        {
            MessageBox.Show("Ça ça çalıştıı.. ");
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            #region DelegeCalistir
            ////x();
            //MyDelegeHandler delege = new MyDelegeHandler(x);
            //delege();
            //MyDelegeHandler delege1 = new MyDelegeHandler(x);
            //delege1.Invoke(); 
            #endregion

            #region ParametreliCalistir
            //IslemYapHandler delege = new IslemYapHandler(Topla);
            //MessageBox.Show(delege(2, 3).ToString());
            ////veya
            //MessageBox.Show(delege.Invoke(2, 3).ToString());
            ////carp ve toplayı adresleyebilir toplayı seçtik biz.


            #region eventProseduruEkle
            //IslemYapHandler delege = new IslemYapHandler(Topla);
            //delege += Carp;
            //MessageBox.Show(delege(2, 3).ToString());
            ////ya da
            //MessageBox.Show(delege.Invoke(2, 3).ToString()); 
            #endregion


            #region EventÇıkar
            //IslemYapHandler delege = new IslemYapHandler(Topla);
            //delege += Carp;
            //delege -= Carp;
            //MessageBox.Show(delege(2, 3).ToString());
            #endregion

            #endregion

            #region DelegeMethodlarınıGor
            //IslemYapHandler delege = new IslemYapHandler(Topla);
            //delege += Carp;
            //Delegate[] metodlarımız = delege.GetInvocationList();
            //foreach (Delegate item in metodlarımız)
            //{
            //    MessageBox.Show("Metodumuzun adı : " + item.Method.Name);
            //    MessageBox.Show("Metodumuzun geri dönüş tipi : " + item.Method.ReturnType);
            //    int sonuc = (int)item.DynamicInvoke(2, 3);
            //    MessageBox.Show("Şuanki metodun sonucu : " + sonuc.ToString());
            //}
            #endregion

        }


        public delegate int IslemYapHandler(int a, int b);
        public int Topla(int s1, int s2)
        {
            return s1 + s2;
        }
        public int Carp(int s1, int s2)
        {
            return s1 * s2;
        }

    }
}
