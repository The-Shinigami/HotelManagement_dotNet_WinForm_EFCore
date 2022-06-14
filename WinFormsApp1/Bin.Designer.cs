namespace WinFormsApp1
{
    partial class Bin
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
            this.button1 = new System.Windows.Forms.Button();
            this.mainFram = new WinFormsApp1.RoundPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(95, 154);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mainFram
            // 
            this.mainFram.BackColor = System.Drawing.Color.White;
            this.mainFram.BorderRadius = 20;
            this.mainFram.Location = new System.Drawing.Point(472, 81);
            this.mainFram.Name = "mainFram";
            this.mainFram.Size = new System.Drawing.Size(200, 192);
            this.mainFram.TabIndex = 2;
            // 
            // Bin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.mainFram);
            this.Controls.Add(this.button1);
            this.Name = "Bin";
            this.Text = "Bin";
            this.ResumeLayout(false);

        }

        #endregion
        private Button button1;
        private RoundPanel mainFram;
    }
}