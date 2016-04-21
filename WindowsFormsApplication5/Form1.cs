using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;

namespace WindowsFormsApplication5
{
    public partial class Form1 : Form
    {
        public List<Pessoa> ObterPessoas()
        {
            List<Pessoa> p = new List<Pessoa>();
            p.Add(new Pessoa { Id = 1, Nome = "José das Couves" });
            p.Add(new Pessoa { Id = 2, Nome = "João das Flores" });
            p.Add(new Pessoa { Id = 3, Nome = "José das Couves 3" });
            p.Add(new Pessoa { Id = 4, Nome = "José das Couves 56" });
            p.Add(new Pessoa { Id = 5, Nome = "José das Couves 78" });
            p.Add(new Pessoa { Id = 6, Nome = "José das Couves 23" });
            p.Add(new Pessoa { Id = 7, Nome = "José das Couves 89" });

            return p;
        }

        public Form1()
        {
            InitializeComponent();
            dataGridView1.DataSource = ObterPessoas();
        }

        decimal valor1 = 0;
        private void btnMais_Click(object sender, EventArgs e)
        {
            valor1 += Convert.ToDecimal(maskedTextBox1.Text);
            lblResultado.Text = valor1.ToString();
            maskedTextBox1.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            dataGridView1.DataSource = 
                ObterPessoas().Where(p => p.Nome.Contains(textBox1.Text)).ToList();
        }
    }

    public class Pessoa
    {
        public int Id { get; set; }
        public string Nome { get; set; }
    }
}
