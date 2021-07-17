using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;


namespace MillMoneyMiner2
{




    public partial class Form2 : Form
    {
        string txtBoxData = "";

        




        int thisint;

        public Form2()
        {
            InitializeComponent();
            thisint = Form1.x;
            this.Show();


        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }



        public void Form2_Load(object sender, EventArgs e)
        {
        }
        public void Form2_Activated(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("FORM2_SHOWN");
         

        }


    }
}