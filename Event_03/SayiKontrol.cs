using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Event_03
{
    class SayiKontrol
    {
        public delegate void SayiKontrolEtHandler();
        public event SayiKontrolEtHandler SayiDurumu;
        int sayi;
        public int Sayi
        {
            get
            {
                return sayi;
            }
            set
            {
                sayi = value;
                if (sayi < 10)
                {
                    if (SayiDurumu != null)
                    {
                        SayiDurumu();
                    }
                }
            }
        }
    }
}
