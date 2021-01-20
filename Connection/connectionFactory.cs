using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using SS_Almoxarifado.ModelDAO;

namespace SS_Almoxarifado.Connection
{
    class connectionFactory
    {
        string strCon = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=|DataDirectory|\db_almoxarifado.accdb";

        OleDbConnection con = new OleDbConnection();

        //Construtor
        public void Conexao()
        {
            con.ConnectionString = strCon;
        }

        //Método Conectar
        public OleDbConnection conectar()
        {
            if (con.State == System.Data.ConnectionState.Closed)
            {
                con.Open();
            }
            return con;
        }

        //Método Desconectar
        public void desconectar()
        {
            if (con.State == System.Data.ConnectionState.Open)
            {
                con.Close();
            }

        }

    }

}

