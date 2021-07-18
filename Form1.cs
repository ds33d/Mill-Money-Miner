<<<<<<< HEAD
﻿using System;
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
        public int millmoney = 0;
        public string logging = "";
        bool mine = true;
        
        void Mining()
        {
            logging = "";
            Debug.WriteLine("MINING STARTED");
            var computerGenRandom = new Random();
            var userGuessRandom = new Random();

            Debug.WriteLine("Setting next numbers");
            var userGuess = userGuessRandom.Next(1000);
            var compGuess = userGuessRandom.Next(1000);

            Debug.WriteLine("About to start guessing");
            while (mine)
            {              

                this.Invoke((MethodInvoker)delegate ()
                {
                    lblCompNum.Text = compGuess.ToString();

                });

                userGuess = userGuessRandom.Next(1000);
                this.Invoke((MethodInvoker)delegate ()
                {

                    logging = logging + userGuess.ToString() + "\n";
                    txtLogger.Text = logging;
                    txtLogger.ScrollToCaret();
                });
                




                if (userGuess.ToString() == compGuess.ToString())
                {
                    millmoney++;                    
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        lblMillCount.Text = millmoney.ToString();
                        txtLogger.Text = null;
                        txtLogger.Text = "You earned another $MILL!";
                    });
                    Thread.Sleep(1000);
                    compGuess = userGuessRandom.Next(1000);
                }

            }
            if (mine == false)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogger.Text = "Mining stopped by user";
                });
            }
            

        }

        public Form1()
        {
            
            InitializeComponent();
            lblMillCount.Text = "None";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnMine_Click(object sender, EventArgs e)
        {

            mine = true;
            Thread thread = new Thread(Mining);
            thread.Start();
            


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

        private void button1_Click(object sender, EventArgs e)
        {
            mine = false;
        }
    }
}
=======
﻿using System;
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
        public int millmoney = 0;
        public string logging = "";
        bool mine = true;
        
        void Mining()
        {
            logging = "";
            Debug.WriteLine("MINING STARTED");
            var computerGenRandom = new Random();
            var userGuessRandom = new Random();

            Debug.WriteLine("Setting next numbers");
            var userGuess = userGuessRandom.Next(1000);
            var compGuess = userGuessRandom.Next(1000);

            Debug.WriteLine("About to start guessing");
            while (mine)
            {

                Debug.WriteLine("Starting guess");
                this.Invoke((MethodInvoker)delegate ()
                {
                    logging = logging + "Starting guess" + "\n";
                    txtLogger.Text = logging;
                    txtLogger.ScrollToCaret();
                });
                Debug.WriteLine("Computer generated number:");
                Debug.WriteLine(compGuess.ToString());

                this.Invoke((MethodInvoker)delegate ()
                {
                    lblCompNum.Text = compGuess.ToString();

                });

                userGuess = userGuessRandom.Next(1000);
                this.Invoke((MethodInvoker)delegate ()
                {

                    logging = logging + userGuess.ToString() + "\n";
                    txtLogger.Text = logging;
                    txtLogger.ScrollToCaret();
                });
                Debug.WriteLine(userGuess.ToString());




                if (userGuess.ToString() == compGuess.ToString())
                {
                    millmoney++;
                    Debug.WriteLine("$MILL you have:");
                    Debug.WriteLine(millmoney.ToString());
                    logging = logging + "You earned another $MILL!";
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        lblMillCount.Text = millmoney.ToString();
                        txtLogger.Text = logging.ToString();
                        txtLogger.ScrollToCaret();
                    });

                    compGuess = userGuessRandom.Next(1000);
                }

            }
            if (mine == false)
            {
                this.Invoke((MethodInvoker)delegate ()
                {
                    txtLogger.Text = "Mining stopped by user";
                });
            }
            

        }

        public Form1()
        {
            
            InitializeComponent();
            lblMillCount.Text = "None";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnMine_Click(object sender, EventArgs e)
        {

            mine = true;
            Thread thread = new Thread(Mining);
            thread.Start();
            


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

        private void button1_Click(object sender, EventArgs e)
        {
            mine = false;
        }
    }
}
>>>>>>> dcbd97b97601ed72592cb2ca252f75a557a149ee
