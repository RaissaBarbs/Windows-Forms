using SistemaGURI.DAL;
using SistemaGURI.Model;
using SistemaGURI.View;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGURIS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void ENTRAR_Click(object sender, EventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();
            List<TBLOGIN> lista = tabela.getTodosLogins();

            bool logou = false;
            foreach (var item in lista)
            {
                if (item.LOGNOME == txtLogin.Text)
                {
                    if (item.LOGSENHA == txtSenha.Text)
                    {
                        logou = true;
                        FormUsuarios frm = new FormUsuarios();
                        frm.Show();

                    }
                }
            }

            if (logou == false)
            {
                MessageBox.Show("Login ou senha inválido");
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
