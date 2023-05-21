
namespace ieskaites_uzdevums
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
            this.butSakt = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // butSakt
            // 
            this.butSakt.BackColor = System.Drawing.Color.AntiqueWhite;
            this.butSakt.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.butSakt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.butSakt.Location = new System.Drawing.Point(458, 455);
            this.butSakt.Name = "butSakt";
            this.butSakt.Size = new System.Drawing.Size(200, 80);
            this.butSakt.TabIndex = 0;
            this.butSakt.Text = "Sākt";
            this.butSakt.UseVisualStyleBackColor = false;
            this.butSakt.Click += new System.EventHandler(this.button1_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(186)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(168, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(867, 164);
            this.label1.TabIndex = 1;
            this.label1.Text = "Cik labi Tu zini Minecraft \r\n          videospēli?";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FloralWhite;
            this.ClientSize = new System.Drawing.Size(1178, 694);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.butSakt);
            this.Name = "Form1";
            this.Text = "Viktorīna";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button butSakt;
        private System.Windows.Forms.Label label1;
    }
}

