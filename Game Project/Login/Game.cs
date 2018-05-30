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
    public partial class Game : Form
    {

        
       
        public Game(string StrText)
        {
            InitializeComponent();
            label1.Text = StrText;
        }
       

        public void Game_Load(object sender, EventArgs e)
        {
            
        }
    }
    
}
