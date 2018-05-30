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
            try
            {

                if (comboBox1.SelectedItem.ToString() == "")
                {
                    MessageBox.Show("Please Click Returning Players Name " +
                                    "or Add New Player Name");

                    this.Close();
                }
            
            else
            {
                Game BlackJack;
                BlackJack = new Game(comboBox1.SelectedItem.ToString());
                BlackJack.ShowDialog();
               
                    // BlackJack.SetLabel1Text(comboBox1.SelectedItem.ToString());
                }

            }
            catch (NullReferenceException )
            {
                MessageBox.Show("Please Click Returning Players Name " +
                                "or Add New Player Name"); 
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
                    string newPlayer = textBox1.Text;
                    StreamWriter sw = new StreamWriter("PlayersList.csv", true);
                    sw.WriteLine("{0},{1},{2}",newPlayer, DateTime.Now.Date,5000);
                    sw.Close();

                    comboBox1.Items.Add(textBox1.Text.ToString());
                
                    Game BlackJack;
                    BlackJack = new Game(textBox1.Text);
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
