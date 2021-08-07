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

    public partial class MainForm : Form
    {


        public int millmoney = 0;
        public string logging = "";
        public int intGuessValue = 999999999;
        public string[] threadNums = new string[6];
        public bool startMine = true;

        public int Mining(int number)
        {
            logging = "";
            int threadnumber = Thread.CurrentThread.ManagedThreadId;
            Debug.WriteLine("Thread number:" + threadnumber);
            threadNums.Append(threadnumber.ToString());

            Debug.WriteLine(number);




            var computerGenRandom = new Random();
            var userGuessRandom = new Random();

            var userGuess = userGuessRandom.Next(intGuessValue);
            var compGuess = computerGenRandom.Next(intGuessValue);


            bool shouldOutput = false;

            int skipCount = 0;


            //Debug.WriteLine("About to start guessing");
            while (startMine)
            {
                
                if (skipCount > 1000000)
                {
                    shouldOutput = true;
                    skipCount = 0;
                }
                else
                {
                    shouldOutput = false;
                    skipCount++;
                }

                //Debug.WriteLine("In the while");
                if (shouldOutput)
                {
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        switch (number)
                        {
                            case 1:
                                lblCompNum.Text = compGuess.ToString();
                                break;
                            case 2:
                                lblCompNum2.Text = compGuess.ToString();
                                break;
                            case 3:
                                lblCompNum3.Text = compGuess.ToString();
                                break;
                            default:
                                Debug.WriteLine(compGuess.ToString());
                                break;
                        }
                    });
                }
                //Debug.WriteLine("Set Userguess");
                userGuess = userGuessRandom.Next(intGuessValue);

                

                if (shouldOutput)
                {

                    this.Invoke((MethodInvoker)delegate ()
                    {

                        switch (number)
                        {
                            case 1:
                                txtLogger.Text = userGuess.ToString();
                                break;
                            case 2:
                                txtLogger2.Text = userGuess.ToString();
                                break;
                            case 3:
                                txtLogger3.Text = userGuess.ToString();
                                break;
                            default:
                                Debug.WriteLine(txtLogger.Text = userGuess.ToString());
                                break;
                        }

                    });

                }

                //Debug.WriteLine("Comp Guess:" + compGuess.ToString());

                //Debug.WriteLine("User Guess:" + userGuess.ToString());

                if (userGuess == compGuess)
                {
                    millmoney++;
                    this.Invoke((MethodInvoker)delegate ()
                    {
                        lblMillCount.Text = millmoney.ToString();
                        txtLogger.Text = "You earned another $MILL!";
                        switch (number)
                        {
                            case 1:
                                lblMillCount.Text = millmoney.ToString();
                                txtLogger.Text = "You earned another $MILL!";
                                break;
                            case 2:
                                lblMillCount.Text = millmoney.ToString();
                                txtLogger2.Text = "You earned another $MILL!";
                                break;
                            case 3:
                                lblMillCount.Text = millmoney.ToString();
                                txtLogger3.Text = "You earned another $MILL!";
                                break;
                            default:
                                Debug.WriteLine(millmoney.ToString());
                                Debug.WriteLine("You earned another $MILL!");
                                break;
                        }

                    });
                    compGuess = userGuessRandom.Next(intGuessValue);
                }

            }
            return 0;
        }




        public MainForm()
        {
            
            InitializeComponent();
            lblMillCount.Text = "None";

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        public void btnMine_Click(object sender, EventArgs e)
        {

            

            startMine = true;
            Task taskA = new Task(() => Mining(1));
            taskA.Start();

            Task taskB = new Task(() => Mining(2));
            taskB.Start();

            Task task3 = new Task(() => Mining(3));
            task3.Start();






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
            startMine = false;
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(startMine == true)
            {
                startMine = false;
                e.Cancel = true;
                Close();
            }
        }
    }
}