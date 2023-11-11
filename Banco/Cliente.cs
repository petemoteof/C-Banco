using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Banco
{
    internal class Cliente
    {
        public string nome;
        public double saldo;

        public void Creditar(double valor)
        {
            if (valor <= 0)
            {
                throw new Exception("Por favor insira um valor Valido = ou > 0 ");
            }


            Conexao conexao = new Conexao();

            string query = "INSERT INTO movimentacao (operacao , valor) VALUES (@valor1 ,@valor2)";

            MySqlParameter[] param = new MySqlParameter[]
            {
                new MySqlParameter("@valor1","credito"),
                new MySqlParameter("@valor2",valor),    
            };

            conexao.ExecuteQueryWithParameters(query, param);

            this.saldo += valor;
        }
        public void Debitar(double valor)
        {
            Cliente cliente = new Cliente();

            if (valor <= cliente.saldo)
            {
                throw new Exception("Por favor insira um valor Valido = ou > 0 ");
            }

            this.saldo -= valor;
        }
    }
}
