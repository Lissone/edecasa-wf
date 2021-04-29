using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using Edecasa.Controllers;
using Edecasa.Models;

namespace Edecasa
{
    public partial class ConfirmarPedido : Form
    {
        private static int pedidoId;
        private static Pedido pedido;
        private static double valor;

        public ConfirmarPedido(int pedId, double val)
        {
            InitializeComponent();

            pedidoId = pedId;
            valor = val;
        }

        //Fazer form de mexer
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);

        private void TodosPedidos_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void TodosPedidos_Load(object sender, EventArgs e)
        {
            var pedidoController = new PedidoController();
            Pedido ped = pedidoController.getOne(pedidoId);

            loadFormasPagamentoComboBox();

            pedido = ped;
            tbtelefone.Text = ped.Cliente.Telefone;
            tbrua.Text = ped.Cliente.Rua;
            tbbairro.Text = ped.Cliente.Bairro;
            tbnumero.Text = ped.Cliente.Numero;
            tbcomplemento.Text = ped.Cliente.Complemento;
            cbpagamento.SelectedIndex = ped.TpPagamentoId;
            tbtaxa.Text = ped.Taxa.ToString();
            tbvalor.Text = valor.ToString();

            //configurando datagrid
            DataGridViewItensInPedido.ColumnCount = 5;
            DataGridViewItensInPedido.Columns[0].Name = "Id";
            DataGridViewItensInPedido.Columns[1].Name = "Quant.";
            DataGridViewItensInPedido.Columns[2].Name = "Produto";
            DataGridViewItensInPedido.Columns[3].Name = "Tamanho";
            DataGridViewItensInPedido.Columns[4].Name = "Valor";

            DataGridViewItensInPedido.Columns["Id"].Visible = false;

            refreshDataGrid();
        }

        private void refreshDataGrid()
        {
            DataGridViewItensInPedido.Rows.Clear();

            var itemController = new ItemController();
            var itens = itemController.getByPedidoId(pedidoId);

            var rows = new List<string[]>();

            foreach (Item item in itens)
            {
                string valor;

                if (item.Tamanho == "Grande")
                    valor = (item.Quantidade * item.Produto.VlGrande).ToString();
                else
                    valor = (item.Quantidade * item.Produto.VlPequeno).ToString();

                string[] row = new string[]
                {
                    item.Id.ToString(),
                    item.Quantidade.ToString(),
                    item.Produto.Descricao,
                    item.Tamanho,
                    valor
                };
                rows.Add(row);
            }

            foreach (string[] row in rows)
            {
                DataGridViewItensInPedido.Rows.Add(row);
            }

            DataGridViewItensInPedido.Sort(DataGridViewItensInPedido.Columns[2], ListSortDirection.Ascending);
        }

        private void loadFormasPagamentoComboBox()
        {
            var tpPagamentoController = new FormasPagamentoController();
            var tpsPagamento = tpPagamentoController.getAll();

            cbpagamento.DisplayMember = "Descricao";
            cbpagamento.DataSource = tpsPagamento;
        }

        private void btnconfirmar_Click(object sender, EventArgs e)
        {
            if (!validation())
                return;

            pedido.TpPagamentoId = cbpagamento.SelectedIndex;
            pedido.Valor = Convert.ToSingle(tbvalor.Text);
            pedido.Taxa = Convert.ToSingle(tbtaxa.Text);

            var pedidoController = new PedidoController();
            bool ret = pedidoController.update(pedido);

            if(!ret)
            {
                MessageBox.Show("Ocorreu um erro ao atualizar o pedido", "Atualização de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            Home.pedidoId = 0;

            MessageBox.Show("Pedido finalizado!", "Atualização de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private bool validation()
        {
            if (tbvalor.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o valor do pedido", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (cbpagamento.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira o tipo do pagamento", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
            else if (tbtaxa.Text.Equals(""))
            {
                MessageBox.Show("Por favor, ensira a taxa de entrega", "Cadastro de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }

            return true;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void tbvalor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbtaxa.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }

        private void tbtaxa_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '.' || e.KeyChar == ',')
            {
                //troca o . pela virgula
                e.KeyChar = ',';
                //Verifica se já existe alguma vírgula na string
                if (tbtaxa.Text.Contains(","))
                {
                    e.Handled = true; // Caso exista, aborte 
                }
            }
            //aceita apenas números, tecla backspace.
            else if (!char.IsNumber(e.KeyChar) && !(e.KeyChar == (char)Keys.Back))
            {
                e.Handled = true;
            }
        }
    }
}
