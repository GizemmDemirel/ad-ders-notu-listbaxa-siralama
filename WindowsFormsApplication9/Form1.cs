using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication9
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int sayi;
        int sayac = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            panel1.Visible = true;
            panel2.Visible = false;
            sayi = Convert.ToInt32(textBox1.Text);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            string[] ogrenciler = new string[sayi];
            ogrenciler[sayac] = (textBox2.Text);
            sayac++;
            for (int i = 0; i < sayac; i++)
            {

            }
        }
        string[] isimler = new string[7];
        int[] notlar = new int[7];
        int index;
        private void button1_Click_1(object sender, EventArgs e)
        {
            if (index < isimler.Length)
            {
                isimler[index] = textBox1.Text;
                notlar[index] = Convert.ToInt32(textBox2.Text);
            }
            index++;
            textBox1.Text = "";
            textBox2.Text = "";
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            for (int i = 0; i < isimler.Length; i++)

                if (isimler[i] != null)
                {
                    listBox1.Items.Add(isimler[i] + "/" + notlar[i]);
                }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            int enyuksek = notlar[0];
            for (int i = 0; i < notlar.Length; i++)
                if (notlar[i] > enyuksek)
                {
                    enyuksek = notlar[i];
                }
            textBox3.Text = enyuksek.ToString();


        }

        private void button4_Click(object sender, EventArgs e)
        {
            int endusuk=notlar[0];
            for(int i = 0; i < notlar.Length; i++)
                if (notlar[i] < endusuk)
            {
             endusuk=notlar[i];  
            }
            textBox4.Text = endusuk.ToString();
            }
            
            
    }
}
