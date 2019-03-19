using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace практика
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e){}private void label5_Click(object sender, EventArgs e){  }private void textBox3_TextChanged(object sender, EventArgs e){ }
        private void Form1_Load(object sender, EventArgs e)
        {}

        public static int goods, s, k;
        //public static int[] costs = new int[goods];
        int t = 0;
        private void button1_Click(object sender, EventArgs e)
        {
            textBox2.Text = null;
            goods = Int32.Parse(textBox1.Text);// amount of goods

            int[] costs = new int[goods];
            for (int i = t; i < goods; i++)
            {
                string result;
                int ty;
                do
                {
                   result = Microsoft.VisualBasic.Interaction.InputBox("Введите стоимость товара:");
                   ty = Convert.ToInt32(result);

                } while (ty<0);
                costs[i] += Convert.ToInt32(result);
                textBox2.Text += "Стоимость товара: \n";
                textBox2.Text += result + " руб.; \n";
            };

            // sum
            s = costs.Sum();
            textBox3.Text = s.ToString();

            //>1000
            int km = 0;
            for (int g = t; g < goods; g++)
            {                
                if (costs[g] > 1000) km++;
            };
            textBox4.Text = km.ToString();
        }

        private void button2_Click(object sender, EventArgs e)
        {      
        }
    }
}
