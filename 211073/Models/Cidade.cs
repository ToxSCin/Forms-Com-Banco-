using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;
using System.Windows.Forms;

namespace _211073.Models
{
    public class Cidade
    {
        public int Id { get; set; }
        public string nome { get; set; }
        public string uf { get; set; }
    }

}
