using Dapper;
using SistemaGURI.Models;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGURI.DAL
{
    class TBLOGINDAO
    {
        SqlConnection conexao;
        public TBLOGINDAO()
        {
            conexao = new SqlConnection(@"Server=.\SENAI2022; Database=BDGURIS; User Id =sa; Password=senai.123;");
        }

        public List<TBLOGIN> getTodosLogins()
        {

            string sql = "select * from TBLOGIN";
            var dados = (List<TBLOGIN>) conexao.Query<TBLOGIN>(sql);



            return dados;
        }

        public bool SetInserirLogin(TBLOGIN plogin)
        {
            string sql = "INSERT TBLOGIN (LOGNOME, LOGSENHA) values (@LOGNOME, @LOGSENHA)";
            var dados = conexao.Execute( sql, plogin);

            if (dados > 0)
            {
                return true;
            }
            else
            {
                return true;
            }
        }   

    }
}
