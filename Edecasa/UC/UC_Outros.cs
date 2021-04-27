using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Edecasa.Controllers;
using Edecasa.Models;

namespace Edecasa
{
    public partial class UC_Outros : UserControl
    {
        private static int pedidoId;
        public static bool refresh;
        public UC_Outros()
        {
            InitializeComponent();

            pedidoId = 0;
        }
        public UC_Outros(int pedId)
        {
            InitializeComponent();

            pedidoId = pedId;
        }

        private void UC_Outros_Load(object sender, EventArgs e)
        {
            refreshDataGrid();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (DataGridViewOutros.SelectedRows.Count == 0 && (cbfiltrar.Text == "" || cbfiltrar.Text == "Todos"))
            {
                btneditar.Visible = false;
                btnexcluir.Visible = false;
            }
            else
            {
                btneditar.Visible = true;
                btnexcluir.Visible = true;
            }

            if (refresh)
            {
                refreshDataGrid();
                refresh = false;
            }
        }

        private void refreshDataGrid()
        {
            var produtoController = new ProdutoController();
            var produtos = produtoController.getByCategoria("Outro");

            var data = from produto in produtos
                       select new
                       {
                           Id = produto.Id,
                           Descricao = produto.Descricao,
                           Valor_Pequeno = produto.VlPequeno,
                           Valor_Grande = produto.VlGrande
                       };

            DataGridViewOutros.DataSource = data.ToList();
        }

        private void tbbusca_TextChanged(object sender, EventArgs e)
        {
            if (tbbusca.Text == "")
            {
                refreshDataGrid();
                return;
            }

            if (cbfiltrar.Text == "Todos")
            {
                refreshDataGrid();
            }
            else if (cbfiltrar.Text == "Id")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Outro");

                var data = from produto in produtos
                           where produto.Id == Convert.ToInt32(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewOutros.DataSource = data.ToList();
            }
            else if (cbfiltrar.Text == "Descrição")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Outro");

                var data = from produto in produtos
                           where produto.Descricao.Contains(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewOutros.DataSource = data.ToList();
            }
            else if (cbfiltrar.Text == "Valor")
            {
                var produtoController = new ProdutoController();
                var produtos = produtoController.getByCategoria("Outro");

                var data = from produto in produtos
                           where produto.VlGrande == Convert.ToDouble(tbbusca.Text) || produto.VlPequeno == Convert.ToDouble(tbbusca.Text)
                           select new
                           {
                               Id = produto.Id,
                               Descricao = produto.Descricao,
                               Valor_Pequeno = produto.VlPequeno,
                               Valor_Grande = produto.VlGrande
                           };

                DataGridViewOutros.DataSource = data.ToList();
            }
        }

        private void DataGridViewOutros_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (pedidoId == 0)
            {
                MessageBox.Show("Crie um pedido para adicioná-lo na sacola!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            int id = Convert.ToInt32(DataGridViewOutros.CurrentRow.Cells["Id"].Value);

            Item item = new Item { ProdutoId = id, PedidoId = pedidoId };

            ConfirmarItem quantidadeForm = new ConfirmarItem(item);
            quantidadeForm.ShowDialog();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            if (DataGridViewOutros.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridViewOutros.CurrentRow.Cells["Id"].Value);
                string descricao = DataGridViewOutros.CurrentRow.Cells["Descricao"].Value.ToString();
                double vlGrande = Convert.ToDouble(DataGridViewOutros.CurrentRow.Cells["Valor_Grande"].Value);
                double vlPequeno = Convert.ToDouble(DataGridViewOutros.CurrentRow.Cells["Valor_Pequeno"].Value);
                string categoria = "Outro";

                Produto produto = new Produto { Id = id, Descricao = descricao, VlGrande = vlGrande, VlPequeno = vlPequeno, Categoria = categoria };

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja editar essa linha?", "Editar Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                if (dialog == DialogResult.Yes)
                {
                    ProdutoCadastrarEditar produtoForm = new ProdutoCadastrarEditar(produto);
                    produtoForm.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Editar Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnexcluir_Click(object sender, EventArgs e)
        {
            if (DataGridViewOutros.SelectedRows.Count == 1)
            {
                int id = Convert.ToInt32(DataGridViewOutros.CurrentRow.Cells["Id"].Value);

                DialogResult dialog = MessageBox.Show("Você tem certeza que deseja excluir este registro?", "Exclusão de Registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (dialog == DialogResult.Yes)
                {
                    var produtoController = new ProdutoController();
                    var ret = produtoController.delete(id);

                    if (ret)
                    {
                        MessageBox.Show("Registro excluido com sucesso!", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        refreshDataGrid();
                    }
                    else
                    {
                        MessageBox.Show("Ocorreu um erro! Tente novamente.", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            else
            {
                MessageBox.Show("Por favor, selecione uma linha", "Exclusão de Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            ProdutoCadastrarEditar abrirform = new ProdutoCadastrarEditar("Outro");
            abrirform.ShowDialog();
        }
    }
}
