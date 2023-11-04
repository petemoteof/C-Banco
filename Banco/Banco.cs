using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    public partial class Form : System.Windows.Forms.Form
    {
        Cliente cliente;


        public Form()
        {
            InitializeComponent();

            this.cliente = new Cliente();


        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void arquivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void buttonDepositar_Click(object sender, EventArgs e)
        {
            try
            {
                double valor = Convert.ToDouble(textBoxDeposito.Text);

                cliente.Creditar(valor);

                textBoxDeposito.Clear();
                
                MessageBox.Show("Deposito Realizado");

                labelSaldoValor.Text = cliente.saldo.ToString();

            }
            catch(Exception exception)
            {
                textBoxDeposito.Clear();
                MessageBox.Show(exception.Message);
            }
        }


        private void buttonSacar_Click(object sender, EventArgs e)
        {
            double valor = Convert.ToDouble((string)textBoxSacar.Text);

            try
            {
                cliente.Debitar(valor);

                MessageBox.Show("Saque Realizado");

                labelSaldoValor.Text = cliente.saldo.ToString();
            }

            catch (Exception exception)
            {
                MessageBox.Show(exception.Message);
            }

        }
    }
}
