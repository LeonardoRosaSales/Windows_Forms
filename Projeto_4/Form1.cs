using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button_limpar_Click(object sender, EventArgs e)
        {
            //textBox_nome.Text = "";
            textBox_nome.Clear();
            //comboBox_destino.Text = "";
            comboBox_destino.Text = string.Empty;
            radioButton_aviao.Checked = false;
            radioButton_onibus.Checked = false;
            dateTimePicker_data.Value = DateTime.Now;
        }

        private void button_confirmar_Click(object sender, EventArgs e)
        {
            if (textBox_nome.Text.Length == 0)
            {
                MessageBox.Show("Digite seu nome");
                textBox_nome.Focus();
            }

            if (comboBox_destino.Text == "")
            {
                MessageBox.Show("Escolhe não selecionado!");
                comboBox_destino.Focus();
            }

            if (radioButton_aviao.Checked == false && radioButton_onibus.Checked == false)
            {
                MessageBox.Show("Meio de Transporte não selecionado");
                radioButton_aviao.Focus();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.ClientSize = new System.Drawing.Size(640, 190);
            groupBox_valores.Visible = false;
        }

        private void button_calcular_Click(object sender, EventArgs e)
        {
            double gasto_destino, gasto_transporte, gasto_total;

            switch (comboBox_destino.Text.ToUpper())
            {
                case "SP":
                    gasto_destino = 1000;
                    break;
                case "RJ":
                    gasto_destino = 1500;
                    break;
                case "SC":
                    gasto_destino = 2000;
                    break;
                default:
                    gasto_destino = 0;
                    break;
            }

            if (radioButton_aviao.Checked == true)
            {
                gasto_transporte = 100;
            }
            else
            {
                gasto_transporte = 30;
            }

            gasto_total = gasto_transporte + gasto_destino;

            this.ClientSize = new System.Drawing.Size(640, 300);
            groupBox_valores.Visible = true;

            label_numero_destino.Text = gasto_destino.ToString("F2");
            label_numero_transp.Text = gasto_transporte.ToString("F2");
            label_numero_total.Text = gasto_total.ToString("F2");
        }
    }
}
