using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Data.SqlClient;
using System.Net.NetworkInformation;
using System.Data;

namespace Edecasa.Classes
{
    class Validation
    {
        public void FinalizarPedidoValidation()
        {
            if (CadastrarPedido.data.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a hora do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.hora.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a data do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.telefone.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o telefone do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.nome.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o nome cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.rua.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a rua do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.bairro.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o bairro do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.numero.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o numero da casa do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.pagamento.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a forma de pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.valor.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (CadastrarPedido.taxa.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor da taxa do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                CadastrarPedido.validacao = "1";
            }
        }
    }
}
