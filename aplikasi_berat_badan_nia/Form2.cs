using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_berat_badan_nia
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void buttonHitung_Click(object sender, EventArgs e)
        {
            double weight = Convert.ToDouble(textBoxBerat.Text);
            double hight = Convert.ToDouble(textBoxTinggi.Text);
            double result = 0.0;
            string result2 = "";
            string keterangan = "kategori badan kamu adalah";

            if (rbKg.Checked)
            {
                result = weight / (hight * hight);
            }

            else if (rbPon.Checked)
            {
                weight = weight / 2.205;
                result = weight / (hight * hight);
            }

            if (result < 18.5)
            {
                result2 = " Kekurangan Berat Badan";
            }
            else if (result < 25)
            {
                result2 = " Ideal";
            }
            else if (result < 30)
            {
                result2 = " Kelebihan Berat Badan";
            }
            else if (result >= 30)
            {
                result2 = " ObesitasI";
            }
            else if (result >= 35)
            {
                result2 = "  ObesitasII";
            }

            keterangan = "Kategori badan kamu adalah :" + result.ToString ("#.#") + "\r\n" + result2;
        }

        private void closeBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

