namespace WindowsFormsApp1
{
    partial class Form1
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
            this.btnYaz = new System.Windows.Forms.Button();
            this.btnSil = new System.Windows.Forms.Button();
            this.lblAd = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnYaz
            // 
            this.btnYaz.Location = new System.Drawing.Point(102, 107);
            this.btnYaz.Name = "btnYaz";
            this.btnYaz.Size = new System.Drawing.Size(110, 57);
            this.btnYaz.TabIndex = 0;
            this.btnYaz.Text = "yaz";
            this.btnYaz.UseVisualStyleBackColor = true;
            this.btnYaz.Click += new System.EventHandler(this.btnYaz_Click);
            // 
            // btnSil
            // 
            this.btnSil.Location = new System.Drawing.Point(102, 217);
            this.btnSil.Name = "btnSil";
            this.btnSil.Size = new System.Drawing.Size(110, 57);
            this.btnSil.TabIndex = 1;
            this.btnSil.Text = "sil";
            this.btnSil.UseVisualStyleBackColor = true;
            this.btnSil.Click += new System.EventHandler(this.btnSil_Click);
            // 
            // lblAd
            // 
            this.lblAd.AutoSize = true;
            this.lblAd.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lblAd.Location = new System.Drawing.Point(387, 189);
            this.lblAd.Name = "lblAd";
            this.lblAd.Size = new System.Drawing.Size(359, 37);
            this.lblAd.TabIndex = 2;
            this.lblAd.Text = "___________________";
            this.lblAd.Click += new System.EventHandler(this.lblAd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblAd);
            this.Controls.Add(this.btnSil);
            this.Controls.Add(this.btnYaz);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnYaz;
        private System.Windows.Forms.Button btnSil;
        private System.Windows.Forms.Label lblAd;
    }
}

