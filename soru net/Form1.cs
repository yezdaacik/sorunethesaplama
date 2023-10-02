using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace soru_net
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnHesapla_Click(object sender, EventArgs e)
        {
            double dogru, yanlis, sonuc;

            dogru = Convert.ToDouble(txtDogru.Text);
            yanlis = Convert.ToDouble(txtYanlis.Text);

            lblSonuc.Text = (dogru - yanlis / 4.0).ToString();


        }
    }
}
