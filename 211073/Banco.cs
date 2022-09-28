using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Windows.Forms;
using MySql.Data.MySqlClient; 

namespace _211073
{
    public class Banco
    {
        // Criando As Variaveis Publicas para conexção
        public static MySqlConnection Conexão;
        // Command Responsalvel pela instruções Sql
        public static MySqlCommand Comando;
        // Adapter liga os controles do banco de dados
        public static MySqlDataAdapter Adaptador;
        // Liga Banco Com DataSource
        public static DataTable datTabela;



    }
}
