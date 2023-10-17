using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ay
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            int ayAd=comboBox1.SelectedIndex;
            if (ayAd == 11 || ayAd == 0 || ayAd == 1)
            {
                label1.Text = "Kış ayı.";
            }
            else if(ayAd==2||ayAd==3 || ayAd == 4)
            {
                label1.Text = "İlkbahar ayı.";
            }
            else if(ayAd== 5||ayAd == 6 || ayAd == 7)
            {
                label1.Text = "Yaz ayı.";
            }
            else
            {
                label1.Text = "Sonbahar ayı.";
            }
        }
    }
}
