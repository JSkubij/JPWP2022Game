
namespace JpwpGame
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
            this.components = new System.ComponentModel.Container();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.postac = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.postac)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 20;
            this.timer1.Tick += new System.EventHandler(this.ruchTimer);
            // 
            // postac
            // 
            this.postac.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.postac.Location = new System.Drawing.Point(431, 542);
            this.postac.Name = "postac";
            this.postac.Size = new System.Drawing.Size(63, 59);
            this.postac.TabIndex = 0;
            this.postac.TabStop = false;
            this.postac.Click += new System.EventHandler(this.pictureBox1_Click);
            this.postac.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.postac_PreviewKeyDown);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 601);
            this.Controls.Add(this.postac);
            this.Name = "Form2";
            this.Text = "Form2";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form2_FormClosed);
            this.Load += new System.EventHandler(this.Form2_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.gora);
            ((System.ComponentModel.ISupportInitialize)(this.postac)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox postac;
    }
}