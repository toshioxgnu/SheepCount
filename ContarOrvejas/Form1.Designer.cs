namespace ContarOrvejas
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
            this.totalOveja = new System.Windows.Forms.Label();
            this.cuentaoveja = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // totalOveja
            // 
            this.totalOveja.AutoSize = true;
            this.totalOveja.Location = new System.Drawing.Point(140, 209);
            this.totalOveja.Name = "totalOveja";
            this.totalOveja.Size = new System.Drawing.Size(0, 13);
            this.totalOveja.TabIndex = 1;
            // 
            // cuentaoveja
            // 
            this.cuentaoveja.Location = new System.Drawing.Point(67, 27);
            this.cuentaoveja.Name = "cuentaoveja";
            this.cuentaoveja.Size = new System.Drawing.Size(169, 84);
            this.cuentaoveja.TabIndex = 2;
            this.cuentaoveja.Text = "Suma Oveja";
            this.cuentaoveja.UseVisualStyleBackColor = true;
            this.cuentaoveja.Click += new System.EventHandler(this.cuentaoveja_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(65, 296);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(155, 98);
            this.button1.TabIndex = 3;
            this.button1.Text = "Me dormi ";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(304, 551);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.cuentaoveja);
            this.Controls.Add(this.totalOveja);
            this.Name = "Form1";
            this.Text = "Cuenta Ovejas";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label totalOveja;
        private System.Windows.Forms.Button cuentaoveja;
        private System.Windows.Forms.Button button1;
    }
}

