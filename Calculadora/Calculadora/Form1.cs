using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculadora
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int valor1;
            int valor2;
            string tipoOperacao;

            int resultado = -111111;

            string algoritmo = text_operacao.Text;

            string sinais = "+-/*";

            int index = 0;
            foreach (char c in algoritmo) {

                foreach (char s in sinais) {

                    if (c == s) {

                        valor1 = int.Parse(algoritmo.Substring(0,index));

                        tipoOperacao = c.ToString();

                        valor2 = int.Parse(algoritmo.Substring(index + 1));

                        switch (tipoOperacao) {
                            case "+":
                                resultado = valor1 + valor2;
                                break;

                            case "-":
                                resultado = valor1 - valor2;
                                break;

                            case "/":
                                resultado = valor1 / valor2;
                                break;

                            case "*":
                                resultado = valor1 * valor2;
                                break;
                        }
                        break;
                    }
                }
                if (resultado != -111111)
                    break;
                index++;
            }

            if (resultado == -111111)
                MessageBox.Show("Erro na operação!");
            else
            MessageBox.Show(algoritmo + " = " + resultado);
            text_operacao.Text = "";
            text_operacao.Focus();

        }

        private void text_operacao_KeyDown(object sender, KeyEventArgs e)
        {
            if (text_operacao.Text == "") return;

            if (e.KeyCode == Keys.Return)
                button2_Click(cmd_calcular, EventArgs.Empty);
            else if (e.KeyCode == Keys.Escape)
                text_operacao.Text = "";
            text_operacao.Focus();  
        }
    }
}
