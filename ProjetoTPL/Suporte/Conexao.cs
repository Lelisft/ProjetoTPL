﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoTPL.Suporte
{
    public class Conexao
    {
        public SqlConnection conexao = null;
        public Conexao()
        {
            conexao = new SqlConnection(
            ConfigurationManager.ConnectionStrings["conexao"].ConnectionString);
        }
    }
}
