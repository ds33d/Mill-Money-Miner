
namespace MillMoneyMiner2
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMine = new System.Windows.Forms.Button();
            this.lblCompNum = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtLogger = new System.Windows.Forms.MaskedTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblMillCount = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.txtLogger2 = new System.Windows.Forms.MaskedTextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.lblCompNum2 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblCompNum3 = new System.Windows.Forms.Label();
            this.txtLogger3 = new System.Windows.Forms.MaskedTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(298, 291);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // btnMine
            // 
            this.btnMine.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.btnMine.Location = new System.Drawing.Point(12, 297);
            this.btnMine.Name = "btnMine";
            this.btnMine.Size = new System.Drawing.Size(153, 85);
            this.btnMine.TabIndex = 1;
            this.btnMine.Text = "Mine 🪓";
            this.btnMine.UseVisualStyleBackColor = true;
            this.btnMine.Click += new System.EventHandler(this.btnMine_Click);
            // 
            // lblCompNum
            // 
            this.lblCompNum.AutoSize = true;
            this.lblCompNum.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompNum.Location = new System.Drawing.Point(12, 19);
            this.lblCompNum.Name = "lblCompNum";
            this.lblCompNum.Size = new System.Drawing.Size(68, 30);
            this.lblCompNum.TabIndex = 4;
            this.lblCompNum.Text = "label2";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblCompNum);
            this.groupBox1.Controls.Add(this.txtLogger);
            this.groupBox1.Location = new System.Drawing.Point(317, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(121, 86);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "To Guess";
            // 
            // txtLogger
            // 
            this.txtLogger.Location = new System.Drawing.Point(12, 52);
            this.txtLogger.Name = "txtLogger";
            this.txtLogger.Size = new System.Drawing.Size(100, 23);
            this.txtLogger.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblMillCount);
            this.groupBox2.Location = new System.Drawing.Point(317, 196);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(103, 56);
            this.groupBox2.TabIndex = 7;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "$MILL Count:";
            // 
            // lblMillCount
            // 
            this.lblMillCount.AutoSize = true;
            this.lblMillCount.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMillCount.Location = new System.Drawing.Point(6, 18);
            this.lblMillCount.Name = "lblMillCount";
            this.lblMillCount.Size = new System.Drawing.Size(68, 30);
            this.lblMillCount.TabIndex = 0;
            this.lblMillCount.Text = "label2";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.button1.Location = new System.Drawing.Point(171, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(139, 85);
            this.button1.TabIndex = 8;
            this.button1.Text = "STOP🛑";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtLogger2
            // 
            this.txtLogger2.Location = new System.Drawing.Point(7, 57);
            this.txtLogger2.Name = "txtLogger2";
            this.txtLogger2.Size = new System.Drawing.Size(100, 23);
            this.txtLogger2.TabIndex = 10;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.lblCompNum2);
            this.groupBox3.Controls.Add(this.txtLogger2);
            this.groupBox3.Location = new System.Drawing.Point(444, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(118, 86);
            this.groupBox3.TabIndex = 7;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "To Guess";
            // 
            // lblCompNum2
            // 
            this.lblCompNum2.AutoSize = true;
            this.lblCompNum2.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompNum2.Location = new System.Drawing.Point(6, 24);
            this.lblCompNum2.Name = "lblCompNum2";
            this.lblCompNum2.Size = new System.Drawing.Size(101, 30);
            this.lblCompNum2.TabIndex = 4;
            this.lblCompNum2.Text = "lblGuess2";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblCompNum3);
            this.groupBox4.Controls.Add(this.txtLogger3);
            this.groupBox4.Location = new System.Drawing.Point(317, 104);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(121, 86);
            this.groupBox4.TabIndex = 9;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "To Guess";
            // 
            // lblCompNum3
            // 
            this.lblCompNum3.AutoSize = true;
            this.lblCompNum3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCompNum3.Location = new System.Drawing.Point(12, 19);
            this.lblCompNum3.Name = "lblCompNum3";
            this.lblCompNum3.Size = new System.Drawing.Size(68, 30);
            this.lblCompNum3.TabIndex = 4;
            this.lblCompNum3.Text = "label2";
            // 
            // txtLogger3
            // 
            this.txtLogger3.Location = new System.Drawing.Point(12, 52);
            this.txtLogger3.Name = "txtLogger3";
            this.txtLogger3.Size = new System.Drawing.Size(100, 23);
            this.txtLogger3.TabIndex = 9;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(583, 400);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnMine);
            this.Controls.Add(this.pictureBox1);
            this.Name = "MainForm";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnMine;
        private System.Windows.Forms.Label lblCompNum;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblMillCount;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.MaskedTextBox txtLogger;
        private System.Windows.Forms.MaskedTextBox txtLogger2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label lblCompNum2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblCompNum3;
        private System.Windows.Forms.MaskedTextBox txtLogger3;
    }

}

