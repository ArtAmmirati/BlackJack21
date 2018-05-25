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

namespace Players_List
{
    public partial class PlayerRegestration : Form
    {
        public PlayerRegestration()
        {
            InitializeComponent();
        }
        
        PlayerTable playerTable = new PlayerTable();

        public void button1_Click(object sender, EventArgs e)
        {

            playerTable.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }
    }
}
