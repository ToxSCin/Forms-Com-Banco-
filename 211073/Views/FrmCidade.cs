using _211073.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _211073.Views;
namespace _211073.Views
{
    public partial class FrmCidade : Form
    {
        Cidade c;
        public FrmCidade()
        {
            InitializeComponent();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {

        }
        private void carregarGrid(string pesquisa)
        {
            c = new Cidade()
            {
                nome = pesquisa
            };
        }

        private void limparControles()
        {
            textBox2.Clear();
            textBox4.Clear();
            textBox1.Clear();
            textBox3.Clear();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            limparControles();
            carregarGrid("");
        }

        private void button4_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == String.Empty) return;
            { 

                c = new Cidade()
                {
                    nome = textBox2.Text,
                    uf = textBox4.Text
                };
                c.incluir();

                limparControles();
                carregarGrid("");
            }
         
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {
            carregarGrid(Pesquisar.Text);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
