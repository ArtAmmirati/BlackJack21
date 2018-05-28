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
    public partial class Resgister : Form
    {
        public Resgister()
        {
            InitializeComponent();
        }
        
        private void Form2_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader inputFile = File.OpenText("PlayersList.csv");  // to read the file
                string line;      // to hold a line from the file
                int count = 0;    //counter
                
                
                // Create a delimiter array
                char[] delim = {','};

                while (!inputFile.EndOfStream)
                {
                   
                    line = inputFile.ReadLine();
                    string[] tokens = line.Split(delim);
                    comboBox1.Items.Add(tokens[0]);
                    count++;
                    //comboBox1.Items.Clear();
                }
               
                inputFile.Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            

            if (comboBox1.Text.ToString() == "" && textBox1.Text == "")
            {
                MessageBox.Show("Please Click Returning Players Name " +
                                "or Add New Player Name");
                this.Close();

            }
            else if (comboBox1.Text.ToString() == "" || textBox1.Text == "")
            {
                MessageBox.Show("Please Click Returning Players Name " +
                                                "or Add New Player Name");
                this.Close();
            }
            else
            {
                

                Game BlackJack;
                BlackJack = new Game();
                BlackJack.ShowDialog();
            }

                
        }

        public void button2_Click(object sender, EventArgs e)
        {

            try
            {
                if (textBox1.Text == "")
                {

                    MessageBox.Show("Enter a Name");
                    this.Close();
                }

                else 
                {
                    comboBox1.Items.Add(textBox1.Text.ToString());
                
                    Game BlackJack;
                    BlackJack = new Game();
                    BlackJack.ShowDialog();

                    

                }
            }
           
            catch (Exception ex)
            {

                throw ex;
            }
        }

     
    }
}
