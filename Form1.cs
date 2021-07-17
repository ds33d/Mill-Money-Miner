using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MillMoneyMiner2
{
    
    public partial class Form1 : Form   
    {
        public static int x = 0;
        
        public Form1()
        {
            
            InitializeComponent();
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnMine_Click(object sender, EventArgs e)
        {

            var formMine = new Form2();
            formMine.Show();



        }
        public void Form2_Activated(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("Activated");

        }
        public void Form2_HandleCreated(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("HandleCreated");

        }
        public void Form2_VisibleChanged(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("VisibleChanged");

        }
        public void Form2_Shown(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine("Shown");

        }
    }
}
