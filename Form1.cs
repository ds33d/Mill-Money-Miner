using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Diagnostics;

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
             void Mining()
            {
                Debug.WriteLine("MINING STARTED");

                var computerGenRandom = new Random();
                var userGuessRandom = new Random();

                Debug.WriteLine("Numbers generated");

                computerGenRandom.Next(100);
                userGuessRandom.Next(100);

                Debug.WriteLine("Computer generated number:" + computerGenRandom.ToString());
                Debug.WriteLine("User generated number:" + userGuessRandom.ToString());

                Debug.WriteLine("Setting next numbers");
                var userGuess = userGuessRandom.Next(100);
                var compGuess = userGuessRandom.Next(100);

                Debug.WriteLine("About to start guessing");
                while (userGuess != compGuess)
                {
                    Debug.WriteLine("Starting guess");
                    Debug.WriteLine("Computer generated number:");
                    Debug.WriteLine(compGuess.ToString());
                    userGuess = userGuessRandom.Next(100);
                    Debug.WriteLine(userGuess.ToString());


                }

               



            }
            Mining();
            formMine.Close();


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
