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
        
        public string Mining(ref string txtBoxData)
        {

            //var computerGenRandom = new Random();
           // var userGuessRandom = new Random();

           // computerGenRandom.Next(1, 100);
          //  userGuessRandom.Next(1, 100);

;
            //  while (userGuessRandom != computerGenRandom)
            //   {
            //      var userGuess = userGuessRandom.Next(1, 100);
            //      txtBoxData = txtBoxData + userGuess.ToString() + "\n";
            //      Console.WriteLine(txtBoxData);
            //
            // }

            System.Diagnostics.Debug.WriteLine("mINING THREAD STARTED");

            
            return txtBoxData;
            
            
        }
       

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
            System.Diagnostics.Debug.WriteLine("FORM2_LOAD");
            this.Activate();

        }
        public void Form2_Activated(object sender, EventArgs e) {
            System.Diagnostics.Debug.WriteLine("FORM2_SHOWN");
            richTextBox1.Text = txtBoxData;
            Thread mining = new Thread(() => Mining(ref txtBoxData));
            mining.Start();
            richTextBox1.AppendText(txtBoxData);
            richTextBox1.ScrollToCaret();

        }


    }
}