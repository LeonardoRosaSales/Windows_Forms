﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Projeto_3
{
    public partial class Form_calculadora : Form
    {
        public Form_calculadora()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label__situacao_Click(object sender, EventArgs e)
        {

        }

        private void label__imc_Click(object sender, EventArgs e)
        {
            double altura, peso, imc;

            peso = double.Parse(textBox__peso.Text);
            altura = Convert.ToDouble(textBox__altura.Text);

            imc = peso / (altura * altura);

            label_result_imc.Text = imc.ToString();

            if(imc < 19 )
            {
                label_result_situacao.Text = "Abaixo do Peso";
            }
            else if (imc >= 19 && imc < 25 )
            {
                label_result_situacao.Text = "Peso Ideal";
            }
            else
            {
                label_result_situacao.Text = "Acima do Peso";
            }
                                 
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja sair?",
                "Confirmação",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question,
                MessageBoxDefaultButton.Button2
                )== DialogResult.Yes);
            {
                this.Close();
            }
            

        }
    }
}
