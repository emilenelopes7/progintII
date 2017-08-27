using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora_Tarefa
{
    public partial class Form1 : Form
    {
        String nome;
        double valor01, valor02, resultado;

        public Form1()
        {
            InitializeComponent();
        }

        private void botaoSubtracao_Click(object sender, EventArgs e)
        {
            valor01 = Convert.ToDouble(textValor01.Text);
            valor02 = Convert.ToDouble(textValor02.Text);

            resultado = valor01 - valor02;

            textTotal.Text = nome + resultado.ToString();
        }

        private void botaoMultiplicacao_Click(object sender, EventArgs e)
        {
            valor01 = Convert.ToDouble(textValor01.Text);
            valor02 = Convert.ToDouble(textValor02.Text);

            resultado = valor01 * valor02;

            textTotal.Text = nome + resultado.ToString();
        }

        private void botaoDivisao_Click(object sender, EventArgs e)
        {
            valor01 = Convert.ToDouble(textValor01.Text);
            valor02 = Convert.ToDouble(textValor02.Text);

            resultado = valor01 / valor02;

            textTotal.Text = nome + string.Format("{0:0.00}", resultado);
        }

        private void botaoLimpar_Click(object sender, EventArgs e)
        {
            textNome.Clear();
            textValor01.Clear();
            textValor02.Clear();
            textTotal.Clear();
        }

        private void botaoSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textNome_TextChanged(object sender, EventArgs e)
        {
            nome = textNome.Text + " o resultado é: ";
        }

        private void botaoSoma_Click(object sender, EventArgs e)
        {
            valor01 = Convert.ToDouble(textValor01.Text);
            valor02 = Convert.ToDouble(textValor02.Text);

            resultado = valor01 + valor02;

            textTotal.Text = nome + resultado.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }
    }
}
