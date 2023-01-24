
namespace SISU_Sistema.View.Aluno
{
    partial class AlunoIndex
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
            this.label1 = new System.Windows.Forms.Label();
            this.NomeAluno = new System.Windows.Forms.Label();
            this.txtBox = new System.Windows.Forms.TextBox();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.listAlunos = new System.Windows.Forms.ListView();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnApagar = new System.Windows.Forms.Button();
            this.Idade = new System.Windows.Forms.Label();
            this.txtIdade = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(99, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Gestão de Alunos";
            // 
            // NomeAluno
            // 
            this.NomeAluno.AutoSize = true;
            this.NomeAluno.Location = new System.Drawing.Point(37, 70);
            this.NomeAluno.Name = "NomeAluno";
            this.NomeAluno.Size = new System.Drawing.Size(40, 15);
            this.NomeAluno.TabIndex = 1;
            this.NomeAluno.Text = "Nome";
            this.NomeAluno.Click += new System.EventHandler(this.label2_Click);
            // 
            // txtBox
            // 
            this.txtBox.Location = new System.Drawing.Point(90, 65);
            this.txtBox.Name = "txtBox";
            this.txtBox.Size = new System.Drawing.Size(229, 23);
            this.txtBox.TabIndex = 2;
            this.txtBox.TextChanged += new System.EventHandler(this.txtBox_TextChanged);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(325, 84);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(80, 25);
            this.btnAdicionar.TabIndex = 3;
            this.btnAdicionar.Text = "adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // listAlunos
            // 
            this.listAlunos.HideSelection = false;
            this.listAlunos.Location = new System.Drawing.Point(90, 123);
            this.listAlunos.Name = "listAlunos";
            this.listAlunos.Size = new System.Drawing.Size(229, 149);
            this.listAlunos.TabIndex = 4;
            this.listAlunos.UseCompatibleStateImageBehavior = false;
            this.listAlunos.SelectedIndexChanged += new System.EventHandler(this.listAlunos_SelectedIndexChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Location = new System.Drawing.Point(137, 300);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(135, 48);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnApagar
            // 
            this.btnApagar.Location = new System.Drawing.Point(547, 94);
            this.btnApagar.Name = "btnApagar";
            this.btnApagar.Size = new System.Drawing.Size(118, 36);
            this.btnApagar.TabIndex = 6;
            this.btnApagar.Text = "Apagar";
            this.btnApagar.UseVisualStyleBackColor = true;
            this.btnApagar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // Idade
            // 
            this.Idade.AutoSize = true;
            this.Idade.Location = new System.Drawing.Point(37, 94);
            this.Idade.Name = "Idade";
            this.Idade.Size = new System.Drawing.Size(36, 15);
            this.Idade.TabIndex = 7;
            this.Idade.Text = "Idade";
            this.Idade.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // txtIdade
            // 
            this.txtIdade.Location = new System.Drawing.Point(90, 94);
            this.txtIdade.Name = "txtIdade";
            this.txtIdade.Size = new System.Drawing.Size(229, 23);
            this.txtIdade.TabIndex = 8;
            this.txtIdade.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // AlunoIndex
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(936, 502);
            this.Controls.Add(this.txtIdade);
            this.Controls.Add(this.Idade);
            this.Controls.Add(this.btnApagar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.listAlunos);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.txtBox);
            this.Controls.Add(this.NomeAluno);
            this.Controls.Add(this.label1);
            this.Name = "AlunoIndex";
            this.Text = "AlunoIndex";
            this.Load += new System.EventHandler(this.AlunoIndex_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label NomeAluno;
        private System.Windows.Forms.TextBox txtBox;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.ListView listAlunos;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnApagar;
        private System.Windows.Forms.Label Idade;
        private System.Windows.Forms.TextBox textIdade;
        private System.Windows.Forms.TextBox txtIdade;
    }
}