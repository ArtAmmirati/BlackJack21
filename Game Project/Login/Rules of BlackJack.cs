﻿using System;
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
    public partial class Rules_of_BlackJack : Form
    {
        public Rules_of_BlackJack()
        {
            InitializeComponent();
        }

        private void Rules_of_BlackJack_Load(object sender, EventArgs e)
        {
           try
            {
                TextReader reader = new StreamReader("Guide2BlackJack.txt");
                richTextBox1.Text = reader.ReadToEnd();
                reader.Close();
            }
            catch (Exception)
            {

                throw;
            }  
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {
           
        }
    }
}
