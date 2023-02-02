using SistemaGURI.DAL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaGURI.View
{
    public partial class FormUsuarios : Form
    {
        public FormUsuarios()
        {
            InitializeComponent();
        }

        private void FormUsuarios_Load(object sender, EventArgs e)
        {
            TBLOGINDAO tabela = new TBLOGINDAO();
            dataGridView1.DataSource = tabela.getTodosLogins();

            dataGridView1.Columns[0].HeaderText = "Código";
            dataGridView1.Columns[1].HeaderText = "Login";
            dataGridView1.Columns[2].HeaderText = "Senha";
        }

       
    }
}
