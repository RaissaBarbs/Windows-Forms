
namespace SistemaGURI
{
    partial class Form1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtLOGIN = new System.Windows.Forms.TextBox();
            this.txtSENHA = new System.Windows.Forms.TextBox();
            this.ENTRAR = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(42, 50);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "LOGIN";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(45, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "SENHA";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtLOGIN
            // 
            this.txtLOGIN.Location = new System.Drawing.Point(119, 47);
            this.txtLOGIN.Name = "txtLOGIN";
            this.txtLOGIN.Size = new System.Drawing.Size(152, 23);
            this.txtLOGIN.TabIndex = 2;
            // 
            // txtSENHA
            // 
            this.txtSENHA.Location = new System.Drawing.Point(119, 80);
            this.txtSENHA.Name = "txtSENHA";
            this.txtSENHA.Size = new System.Drawing.Size(152, 23);
            this.txtSENHA.TabIndex = 3;
            // 
            // ENTRAR
            // 
            this.ENTRAR.Location = new System.Drawing.Point(172, 137);
            this.ENTRAR.Name = "ENTRAR";
            this.ENTRAR.Size = new System.Drawing.Size(149, 38);
            this.ENTRAR.TabIndex = 4;
            this.ENTRAR.Text = "ENTRAR";
            this.ENTRAR.UseVisualStyleBackColor = true;
            this.ENTRAR.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ENTRAR);
            this.Controls.Add(this.txtSENHA);
            this.Controls.Add(this.txtLOGIN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtLOGIN;
        private System.Windows.Forms.TextBox txtSENHA;
        private System.Windows.Forms.Button ENTRAR;
    }
}
