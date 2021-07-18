
namespace MillMoneyMiner2
{
    partial class Form2
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblMine = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblMine
            // 
            this.lblMine.AutoSize = true;
            this.lblMine.Font = new System.Drawing.Font("Segoe UI", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblMine.Location = new System.Drawing.Point(12, 9);
            this.lblMine.Name = "lblMine";
            this.lblMine.Size = new System.Drawing.Size(222, 50);
            this.lblMine.TabIndex = 0;
            this.lblMine.Text = "Mining... 🪓";
            this.lblMine.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(243, 75);
            this.Controls.Add(this.lblMine);
            this.Name = "Form2";
            this.Text = "Mining...";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMine;
    }
}