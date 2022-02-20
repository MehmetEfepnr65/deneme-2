using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DENEME2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            listBox1.Items.Add(textBox1.Text);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int sayac = 0;
            double ortalama;
            int toplam = 0;
            while (sayac < listBox1.Items.Count)
            {
                if (Convert.ToInt32(listBox2.Items[sayac]) % 2 == 1)
                {
                    break;
                }
                    toplam=toplam+Convert.ToInt32(listBox2.Items[sayac]);
                    sayac++;
                    ortalama = toplam / sayac;
                    label1.Text = "Çift sayı" + ortalama;

                  
                    if (Convert.ToInt32(listBox3.Items[sayac]) % 2 == 0)
                    {
                        break;
                    }
                    toplam = toplam + Convert.ToInt32(listBox3.Items[sayac]);
                    sayac++;
                    ortalama = toplam / sayac;
                    label1.Text = "Tek sayı" + ortalama;
                    
            }
        }
    }
}
