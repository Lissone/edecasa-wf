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
        public void BebidaCadastrarEditarValidation()
        {
            if (UC_Bebidas.idbebida.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o id da bebida", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Bebidas.nomebebida.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o nome da bebida", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Bebidas.tamanhobebida.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o tamanho em litro ou ml da bebida", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Bebidas.tamanhobebida.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor da bebida", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UC_Bebidas.validacao = "1";
            }
        }
        public void OutroCadastrarEditarValidation()
        {
            if (UC_Outros.iditem.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o id do item", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Outros.nomeitem.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o nome do item", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Outros.valoritem.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do item", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UC_Outros.validacao = "1";
            }
        }
        public void PizzaCadastrarEditarValidation()
        {
            if (UC_Pizzas.idpizza.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o id da pizza", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Pizzas.nomepizza.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o nome da pizza", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Pizzas.brotopizza.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do tamanho broto", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (UC_Pizzas.grandepizza.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do tamanho grande", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                UC_Pizzas.validacao = "1";
            }
        }
        public void FinalizarPedidoValidation()
        {
            if (FinalizarPedido.data.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a hora do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.hora.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a data do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.telefone.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o telefone do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.nome.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o nome cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.rua.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a rua do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.bairro.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o bairro do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.numero.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o numero da casa do cliente", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.pagamento.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a forma de pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.valor.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else if (FinalizarPedido.taxa.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor da taxa do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                FinalizarPedido.validacao = "1";
            }
        }
    }
}
