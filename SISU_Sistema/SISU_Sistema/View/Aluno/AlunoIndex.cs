using SISU_Sistema.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SISU_Sistema.View.Aluno
{
    public partial class AlunoIndex : Form
    {
        public AlunoIndex()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            
        }

        private void listAlunos_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtBox_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if ((txtBox.Text == "") )
            {
                MessageBox.Show("Nome é obrigatório.");
                txtBox.BackColor = Color.Red;
            }

            if ( (txtIdade.Text!="") )
            {
                MessageBox.Show("Idade é obrigatório.");
                txtIdade.BackColor = Color.Red;
            }
            if ((txtBox.Text != "") & (txtIdade.Text != ""))
            {
                listAlunos.Items.Add(txtBox.Text + " | " + txtIdade.Text);
            }
            if (txtBox.Text == "")
            {
                MessageBox.Show("Nome é obrigatório.");
                txtBox.BackColor = Color.Red;
            }
            if (txtIdade.Text == "")
            {
                MessageBox.Show("Idade é obrigatório.");
                txtIdade.BackColor = Color.Red;
            }
            if ((txtBox.Text != "") & (txtIdade.Text != ""))
            {
                listAlunos.Items.Add(txtBox.Text + " | " + txtIdade.Text);
                txtBox.BackColor = Color.White;
                txtIdade.BackColor = Color.White;
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Alunos.txt");

            foreach (ListViewItem item in listAlunos.Items)
            {
                sw.WriteLine(item.Text);
            }

            sw.Close();
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            StreamWriter sw = new StreamWriter("Aluno.txt");
            sw.Flush();
            sw.Close();
            listAlunos.Clear();

        }

        private void AlunoIndex_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Alunos.txt");

                String linha = sr.ReadLine();
                while (sr.ReadLine() != null)
                {
                    listAlunos.Items.Add(sr.ReadLine());
                }
                sr.Close(); 

            }
            catch (System.IO.FileNotFoundException ex)
            {

                MessageBox.Show("Erro de leitura de Arquivo. Arquivo não existe ou endereço inválido");
            }
        }

        private void label2_Click_1(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
