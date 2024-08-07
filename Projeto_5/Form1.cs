using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_5
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            textBox_valor.Text = string.Empty;
            textBox_valor2.Text = string.Empty;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(260, 120);
            label_resultado.Visible = false;
        }

        private void button_adicao_Click(object sender, EventArgs e)
        {
            double valor, valor2, resultado;

            valor = double.Parse(textBox_valor.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            resultado = valor + valor2;

            label_resultado.Text = resultado.ToString();

            this.ClientSize = new System.Drawing.Size(260, 160);
            label_resultado.Visible = true;
        }

        private void button_subs_Click(object sender, EventArgs e)
        {
            double valor, valor2, resultado;

            valor = double.Parse(textBox_valor.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            resultado = valor - valor2;

            label_resultado.Text = resultado.ToString();

            this.ClientSize = new System.Drawing.Size(260, 160);
            label_resultado.Visible = true;
        }

        private void button_div_Click(object sender, EventArgs e)
        {
            double valor, valor2, resultado;

            valor = double.Parse(textBox_valor.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            resultado = valor / valor2;

            label_resultado.Text = resultado.ToString();

            this.ClientSize = new System.Drawing.Size(260, 160);
            label_resultado.Visible = true;
        }

        private void button_multi_Click(object sender, EventArgs e)
        {
            double valor, valor2, resultado;

            valor = double.Parse(textBox_valor.Text);
            valor2 = double.Parse(textBox_valor2.Text);

            resultado = valor * valor2;

            label_resultado.Text = resultado.ToString();

            this.ClientSize = new System.Drawing.Size(260, 160);
            label_resultado.Visible = true;
        }

        private void button_sair_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                ) == DialogResult.Yes) ;
            {
                this.Close();
            }
        }
    }
}
