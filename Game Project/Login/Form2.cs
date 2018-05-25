using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Login
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

        private void button1_Click(object sender, EventArgs e)
        {
            Form3 BlackJack;
            BlackJack = new Form3();
            BlackJack.ShowDialog();

          


        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                comboBox1.Items.Add(textBox1.Text.ToString());

                textBox1.Clear();
            }
            catch (Exception ex)
            {

                throw ex;
            }
        }
    }
}
