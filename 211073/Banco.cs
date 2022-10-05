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
        public static MySqlConnection Conexao;
        // Command Responsalvel pela instruções Sql
        public static MySqlCommand Comando;
        // Adapter liga os controles do banco de dados
        public static MySqlDataAdapter Adaptador;
        // Liga Banco Com DataSource
        public static DataTable datTabela;




        public static void AbrirConexao()
        {
            try
            {
                Conexao = new MySqlConnection("server=localhost;port=3307;uid=root;pwd=etecjau");
                Conexao.Open();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void FecharConexao()
        {
            try
            {
                Conexao.Close();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        public static void CriarBanco()
        {
            try
            {
                AbrirConexao();
                Comando = new MySqlCommand("CREATE DATABASE IF NOT EXISTS vendas; USE vendas;" + "CREATE TABLE IF NOT EXISTS cidades(id integer auto_increment primary key, nome varchar(40)," + "uf char(02))", Conexao);
                Comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message, "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}

