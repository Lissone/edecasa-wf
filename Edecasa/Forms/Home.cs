using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Windows.Forms;
using Edecasa.Forms;
using Edecasa.Models;
using Edecasa.Controllers;

namespace Edecasa
{
    public partial class Home : Form
    {
        public static bool refresh;
        public static int pedidoId;
        public static double total;

        public Home()
        {
            InitializeComponent();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            pedidoId = 0;
            panelsidehome.Visible = false;

            //configurando datagrid
            DataGridViewItens.ColumnCount = 5;
            DataGridViewItens.Columns[0].Name = "Id";
            DataGridViewItens.Columns[1].Name = "Quant.";
            DataGridViewItens.Columns[2].Name = "Produto";
            DataGridViewItens.Columns[3].Name = "Tamanho";
            DataGridViewItens.Columns[4].Name = "Valor";

            DataGridViewItens.Columns["Id"].Visible = false;

            refreshDataGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            data.Text = "Data: " + DateTime.Now.ToShortDateString();
            hora.Text = "Hora: " + DateTime.Now.ToLongTimeString();

            if (refresh) //atualizar sacola
            {
                refreshDataGrid();
                refresh = false;
            }

            if (pedidoId == 0)
            {
                btnpedido.Enabled = true;
                txtsacola.Visible = false;
                btncancelarpedido.Visible = false;
                DataGridViewItens.Visible = false;
                btnfinalizar.Visible = false;
                btnlimpar.Visible = false;
                txttotal.Visible = false;
                txtrs.Visible = false;
                txtvalor.Visible = false;
                txtvalor.Text = "0";
            }
            else
            {
                btnpedido.Enabled = false;
                txtsacola.Visible = true;
                btncancelarpedido.Visible = true;
                DataGridViewItens.Visible = true;
                btnfinalizar.Visible = true;
                btnlimpar.Visible = true;
                txttotal.Visible = true;
                txtrs.Visible = true;
                txtvalor.Visible = true;
            }
        }

        private void refreshDataGrid()
        {
            DataGridViewItens.Rows.Clear();
            txtvalor.Text = "0";

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

                refreshTotalValue(Convert.ToDouble(valor));
            }

            foreach (string[] row in rows)
            {
                DataGridViewItens.Rows.Add(row);
            }

            DataGridViewItens.Sort(DataGridViewItens.Columns[2], ListSortDirection.Ascending);
        }

        private void refreshTotalValue(double itemValue)
        {
            double total = Convert.ToDouble(txtvalor.Text);

            txtvalor.Text = (total + itemValue).ToString();
        }

        private void btnfinalizar_Click(object sender, EventArgs e)
        {
            if (DataGridViewItens.Rows.Count == 0) //SE SACOLA ESTIVER VAZIA
            {
                MessageBox.Show("É necessário ter algum item na sacola!", "Abrir formulário", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double total = Convert.ToDouble(txtvalor.Text);

            ConfirmarPedido abrirform = new ConfirmarPedido(pedidoId, total);
            abrirform.ShowDialog();

        }

        private void btnlimpar_Click(object sender, EventArgs e)
        {
            if (DataGridViewItens.Rows.Count == 0)//SE SACOLA ESTIVER VAZIA
            {
                MessageBox.Show("Sacola de pedidos já está vazia!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja limpar a sacola?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
                return;

            var itemController = new ItemController();
            var ret = itemController.deleteByPedidoId(pedidoId);

            if (!ret)
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            txtvalor.Text = "0";
            total = 0;
            refresh = true;
        }

        private void btncancelarpedido_Click(object sender, EventArgs e)
        {
            DialogResult dialog = MessageBox.Show("Você tem certeza que deseja cancelar este pedido?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (dialog != DialogResult.Yes)
                return;

            int itensInPedido = DataGridViewItens.Rows.Count;

            var pedidoController = new PedidoController();
            bool retPedido = pedidoController.delete(pedidoId);

            if(!retPedido)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir o pedido.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            if (itensInPedido == 0)
            {
                pedidoId = 0;
                txtvalor.Text = "0";

                MessageBox.Show("Pedido cancelado com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var itemController = new ItemController();
            bool retItem = itemController.deleteByPedidoId(pedidoId);

            if (!retItem)
            {
                MessageBox.Show("Ocorreu um erro ao tentar excluir itens do pedido.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            pedidoId = 0;
            txtvalor.Text = "0";

            MessageBox.Show("Pedido cancelado com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void DataGridViewPedido_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            //DELETAR ITEM SACOLA
            int id = Convert.ToInt16(DataGridViewItens.CurrentRow.Cells["Id"].Value);
            double itemValue = Convert.ToDouble(DataGridViewItens.CurrentRow.Cells["Valor"].Value);

            var itemController = new ItemController();
            bool ret = itemController.deleteById(id);

            if (!ret)
            {
                MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            double total = Convert.ToDouble(txtvalor.Text);
            txtvalor.Text = (total - itemValue).ToString();

            refresh = true;
        }

        private void btnfechar_Click(object sender, EventArgs e)
        {
            if (pedidoId != 0)
            {
                MessageBox.Show("É necessário fechar o pedido para sair.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Close();
        }

        private void btnhome_Click(object sender, EventArgs e)
        {
            UC_Home uch = new UC_Home();
            AdicionarControlesParaPainel(uch);
        }

        private void btnpedido_Click(object sender, EventArgs e)
        {
            panelsidehome.Visible = false;

            UC_Home uch = new UC_Home();
            AdicionarControlesParaPainel(uch);

            CadastrarPedido abrirform = new CadastrarPedido();
            abrirform.ShowDialog();
        }

        private void btnpizzas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnpizzas);
            panelsidehome.Visible = true;

            UC_Pizzas uch = new UC_Pizzas(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void btnbebidas_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnbebidas);
            panelsidehome.Visible = true;

            UC_Bebidas uch = new UC_Bebidas(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void btnoutros_Click(object sender, EventArgs e)
        {
            moveSidePanel(btnoutros);
            panelsidehome.Visible = true;

            UC_Outros uch = new UC_Outros(pedidoId);
            AdicionarControlesParaPainel(uch);
        }

        private void btnajustes_Click(object sender, EventArgs e)
        {
            Ajustes abrirform = new Ajustes();
            abrirform.ShowDialog();
        }

        public void AdicionarControlesParaPainel(Control c)
        {
            c.Dock = DockStyle.Fill;
            panelprincipal.Controls.Clear();
            panelprincipal.Controls.Add(c);
        }

        private void moveSidePanel(Control btn)
        {
            panelsidehome.Top = btn.Top;
            panelsidehome.Height = btn.Height;
        }
    }
}
