using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Exercício___01
{
    public partial class Form1 : Form
    {
        
        public Form1()
        {
            InitializeComponent();
        }
        // funcao para fatoriar o valor recursivamente
        private double fatoriar(double valor)
        {
            if (valor.Equals(0))
                return 1;
            return fatoriar(valor - 1) * valor;
        }
        // funcao para fatoriar o valor interativamente 
        private double fator_i(double valor)
        {
            if (valor.Equals(0))
                return 0;
            double total = 1;
            for (double i = valor; i > 0; i--)
            {
                total *= i;
            }
            return total;
        }
        private double valor_atual;
        //botoes
        private void Interactive(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            valor_atual = Convert.ToDouble(Numero.Text);
            Resultado.Text = fator_i(valor_atual).ToString();
        }

        private void Recursive(object sender, EventArgs e)
        {
            Button clicked = sender as Button;
            valor_atual = Convert.ToDouble(Numero.Text);
            Resultado.Text = fatoriar(valor_atual).ToString();

        }
        // verifica se o valor digitado e um numero
        private void Aprovador(object sender, KeyPressEventArgs e)
        {
            if (!char.IsNumber(e.KeyChar) || e.KeyChar == 8)
                e.Handled = true;
        }
        // impede que o valor seja maior que 50
        private void Valor(object sender, EventArgs e)
        {
            if (Convert.ToInt32(Numero.Text) > 50) Numero.Text = "50";
        }
    }
}
