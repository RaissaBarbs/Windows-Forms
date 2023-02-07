using SistemaGURI.DAL;
using SistemaGURI.Models;
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

namespace SistemaGURI
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();
            List<TBLOGIN> lista = tabela.getTodosLogins();

            bool logou = false;
            foreach (var item in lista)
            {
                if (item.LOGNOME == txtLOGIN.Text)
                {
                    if (item.LOGSENHA == txtSENHA.Text)
                    {
                        logou = true;
                        FormUsuarios frm = new FormUsuarios();
                        frm.Show();
                    }
                }
            }
            if(logou == false)
            {
                MessageBox.Show("Login ou senha inválidos");
            }

        }

        
    }
}
